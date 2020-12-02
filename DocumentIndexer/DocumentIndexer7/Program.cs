using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Abstractions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DIVEX.Core;
using DocumentIndexer.Configuration;
using DocumentIndexer.Implementations;
using DocumentIndexer.Interfaces;
using static DIVEX.Core.DivexUtils;
namespace DocumentIndexer
{
    [DivexCompose]
    public partial class Program
    {
        static void Main(string[] args)
        {
            var settings = ReadSettingsFromConfigurationFile();

            var createDocumentProcessorJoined = CreateApplication();

            var runnable =
                createDocumentProcessorJoined.Invoke(
                    documentsSourcePath: settings.FolderPath,
                    dataContextFactory: new DataContextFactory(settings.ConnectionString),
                    extractorServiceUrl: new Uri("http://localhost"),
                    outputFolderPath: settings.OutputFolderPath,
                    fileSystem: new FileSystem(),
                    restClient: new RestClient());

            runnable.Run();

            Console.WriteLine("Done. Press any key to exit");

            Console.ReadKey();
        }

        public static VarReturn.VR2 CreateApplication()
        {
            var createDocumentProcessor = CreateDocumentGrabberAndProcessor();

            var createProcessor1 =
                createDocumentProcessor
                    .Replace(wordsExtractor: CtorOf<SimpleWordsExtractor>())
                    .Replace(documentWithExtractedWordsStore: CtorOf<DocumentWithExtractedWordsStore>());

            var createProcessor2 =
                createDocumentProcessor
                    .Replace(wordsExtractor: CtorOf<RestBasedWordsExtractor>()
                        .Rename(url_extractorServiceUrl: 0))
                    .Replace(documentWithExtractedWordsStore:
                        CtorOf<FileSystemBasedDocumentWithExtractedWordsStore>());

            var createCompositeProcessor = CtorOf<CompositeRunnable>()
                .ReplaceOne(runnables: createProcessor1)
                .ReplaceLast(runnables: createProcessor2);

            return createCompositeProcessor
                .JoinAllInputs();
        }

        private static VarReturn.VR1 CreateDocumentGrabberAndProcessor()
        {
            return CtorOf<DocumentGrabberAndProcessor>()
                .Replace(documentsSource: CtorOf<FileSystemDocumentsSource>()
                    .Rename(path_documentsSourcePath: 0))
                .Replace(documentProcessor: CtorOf<IndexProcessor>());
        }

        private static Settings ReadSettingsFromConfigurationFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));

            return (Settings)serializer.Deserialize(new MemoryStream(File.ReadAllBytes("Settings.xml")));
        }
    }
}