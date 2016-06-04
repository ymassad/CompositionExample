using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
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

            runnable.Run();

            Console.WriteLine("Done. Press any key to exit");

            Console.ReadKey();
        }

        private static IDocumentProcessor CreateDocumentProcessor(Settings settings)
        {
            return new CompositeDocumentProcessor(
                CreateIndexProcessor(settings),
                CreateDocumentTracker());
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
                new PerformanceCounter("CompositionExample2", "TotalNumberOfProcessedDocuments", readOnly:false));
        }

        private static IDocumentWithExtractedWordsStore CreateDocumentStore(Settings settings)
        {
            return new PerformanceAwareDocumentWithExtractedWordsStore(
                new DocumentWithExtractedWordsStore(
                    new DataContextFactory(settings.ConnectionString)),
                CreatePerformanceRecorder());
        }

        private static IPerformanceRecorder CreatePerformanceRecorder()
        {
            return new AveragePerformanceCounterBasedTimeRecorder(
                new PerformanceCounter("CompositionExample1", "SaveToDatabaseTimeInMilliseconds", readOnly: false),
                new PerformanceCounter("CompositionExample1", "SaveToDatabaseTimeInMillisecondsBase", readOnly: false));
        }

        private static IDocumentsSource CreateDocumentSource(Settings settings)
        {
            return
                new ProcessedDocumentsAwareDocumentsSource(
                    new FileSystemDocumentsSource(settings.FolderPath),
                    new DataContextFactory(settings.ConnectionString));
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
