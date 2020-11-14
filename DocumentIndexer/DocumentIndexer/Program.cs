using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DocumentIndexer.Configuration;
using DocumentIndexer.Implementations;
using DocumentIndexer.Interfaces;

namespace DocumentIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            EnsurePerformanceCountersAreCreated();

            var settings = ReadSettingsFromConfigurationFile();

            var runnable =
                new DocumentGrabberAndProcessor(
                    documentsSource: CreateDocumentSource(settings),
                    documentProcessor: CreateDocumentProcessor(settings));

            var continuousRunnable = new ContinuousRunnable(runnable, waitTimeBetweenRuns: TimeSpan.FromSeconds(5));

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            Task task = Task.Run(() => continuousRunnable.Run(cancellationTokenSource.Token));

            Console.WriteLine("System running. Press any key to exit...");

            Console.ReadKey();

            cancellationTokenSource.Cancel();

            Console.WriteLine("Waiting for task to finish...");

            task.Wait();
        }

        private static IDocumentsSource CreateDocumentSource(Settings settings)
        {
            return new FileSystemDocumentsSource(settings.FolderPath, new FileSystem());
        }

        private static IDocumentProcessor CreateDocumentProcessor(Settings settings)
        {
            return new CompositeDocumentProcessor(
                CreateIndexProcessor(settings),
                CreateDocumentTracker(),
                CreateDocumentMover(settings));
        }

        private static IndexProcessor CreateIndexProcessor(Settings settings)
        {
            return new IndexProcessor(
                wordsExtractor:
                    new SimpleWordsExtractor(),
                documentWithExtractedWordsStore:
                    CreateDocumentStore(settings));
        }

        private static PerformanceCounterBasedDocumentTracker CreateDocumentTracker()
        {
            return new PerformanceCounterBasedDocumentTracker(
                new PerformanceCounterWrapper(
                    new PerformanceCounter("CompositionExample2", "TotalNumberOfProcessedDocuments", readOnly:false)));
        }

        private static DocumentMover CreateDocumentMover(Settings settings)
        {
            return new DocumentMover(settings.FolderPath, settings.MoveToPath, new FileSystem());
        }

        private static IDocumentWithExtractedWordsStore CreateDocumentStore(Settings settings)
        {
            return
                new RetryAwareDocumentWithExtractedWordsStore(
                    new ErrorAwareDocumentWithExtractedWordsStore( 
                        new PerformanceAwareDocumentWithExtractedWordsStore(
                            CreateRealDatabaseDocumentStore(settings),
                            CreatePerformanceRecorder()),
                        CreateErrorReporter()),
                    CreateRetryWaiter(),
                    maximumRetries: 5);
        }

        private static IErrorReporter CreateErrorReporter()
        {
            return new EventLogBasedErrorReporter(
                new EventLogWrapper(
                    new EventLog("Application", ".", "DocumentIndexer")));
        }

        private static IncrementalTimeRetryWaiter CreateRetryWaiter()
        {
            return new IncrementalTimeRetryWaiter(baseWaitTime: TimeSpan.FromSeconds(5));
        }



        private static IDocumentWithExtractedWordsStore CreateRealDatabaseDocumentStore(Settings settings)
        {
            return new DocumentWithExtractedWordsStore(
                new DataContextFactory(settings.ConnectionString));
        }

        private static IPerformanceRecorder CreatePerformanceRecorder()
        {
            return new AveragePerformanceCounterBasedTimeRecorder(
                new PerformanceCounterWrapper(
                    new PerformanceCounter("CompositionExample1", "SaveToDatabaseTimeInMilliseconds", readOnly: false)),
                new PerformanceCounterWrapper(
                    new PerformanceCounter("CompositionExample1", "SaveToDatabaseTimeInMillisecondsBase", readOnly: false)));
        }

        private static Settings ReadSettingsFromConfigurationFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));

            return (Settings)serializer.Deserialize(new MemoryStream(File.ReadAllBytes("Settings.xml")));
        }

        private static void EnsurePerformanceCountersAreCreated()
        {
            if (!PerformanceCounterCategory.Exists("CompositionExample1"))
            {
                PerformanceCounterCategory.Create(
                    "CompositionExample1",
                    "Performance Counters for CompositionExample",
                    PerformanceCounterCategoryType.SingleInstance,
                    new CounterCreationDataCollection(new[]
                    {
                        new CounterCreationData
                        {
                            CounterName = "SaveToDatabaseTimeInMilliseconds",
                            CounterHelp = "The amount of time it takes to save a document in milliseconds",
                            CounterType = PerformanceCounterType.RawFraction
                        },
                        new CounterCreationData
                        {
                            CounterName = "SaveToDatabaseTimeInMillisecondsBase",
                            CounterHelp = "Base counter for SaveToDatabaseTimeInMilliseconds",
                            CounterType = PerformanceCounterType.RawBase
                        }
                    }));
            }

            if (!PerformanceCounterCategory.Exists("CompositionExample2"))
            {
                PerformanceCounterCategory.Create(
                    "CompositionExample2",
                    "Performance Counters for CompositionExample",
                    PerformanceCounterCategoryType.SingleInstance,
                    new CounterCreationDataCollection(new[]
                    {
                        new CounterCreationData
                        {
                            CounterName = "TotalNumberOfProcessedDocuments",
                            CounterHelp = "The total number of processed documents",
                            CounterType = PerformanceCounterType.NumberOfItems64
                        }
                    }));
            }
        }
    }
}
