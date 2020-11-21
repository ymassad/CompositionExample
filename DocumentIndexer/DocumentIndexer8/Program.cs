using System;
using System.IO;
using System.IO.Abstractions;
using System.Xml.Serialization;
using DIVEX.Core;
using DocumentIndexer.Configuration;

namespace DocumentIndexer
{
    [DivexCompose]
    public partial class Program
    {
        static void Main(string[] args)
        {
            var settings = ReadSettingsFromConfigurationFile();

            var runnable = CreateApplication();

            runnable.Invoke(
                documentsSourcePath: settings.FolderPath,
                createDataContext: () => Implementations.StorageModule.CreateDatabaseContext(settings.ConnectionString),
                extractorServiceUrl: new Uri("http://localhost"),
                outputFolderPath: settings.OutputFolderPath,
                fileSystem: new FileSystem(),
                post: Implementations.RestModule.Post);

            Console.WriteLine("Done. Press any key to exit");

            Console.ReadKey();
        }

        [DIVEX.Core.FunctionsClassAttribute(typeof(Implementations.RestModule))]
        public static partial class RestModule
        {
        }
        
        public static VarReturn.VR2 CreateApplication()
        {
            var grabAndProcessDocuments = CreateDocumentGrabberAndProcessor();

            var create1 =
                grabAndProcessDocuments
                    .Inject(extractWords: MainModule.GetWords)
                    .Inject(storeDocumentWithExtractedWords: StorageModule.StoreToTheDatabase);

            var create2 =
                grabAndProcessDocuments
                    .Inject(extractWords: RestModule.GetWordsUsingRestService)
                    .Rename(url_extractorServiceUrl: 0)
                    .Inject(storeDocumentWithExtractedWords: StorageModule.StoreToTheFileSystem);

            var create3 = MainModule.RunMultiple
                .InjectOne(runnables: create1)
                .InjectLast(runnables: create2);

            return create3
                .JoinAllInputs();
        }

        [DIVEX.Core.FunctionsClassAttribute(typeof(Implementations.MainModule))]
        public static partial class MainModule
        {
        }
        
        [DIVEX.Core.FunctionsClassAttribute(typeof(Implementations.StorageModule))]
        public static partial class StorageModule
        {
        }
        
        private static VarReturn.VR1 CreateDocumentGrabberAndProcessor()
        {
            return MainModule.GrabAndProcessorDocuments
                    .Inject(getDocuments: StorageModule.GetDocumentsFromFileSystem
                                                    .Rename(path_documentsSourcePath :0))
                    .Inject(processDocument: MainModule.IndexDocument);
        }

        private static Settings ReadSettingsFromConfigurationFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));

            return (Settings)serializer.Deserialize(new MemoryStream(File.ReadAllBytes("Settings.xml")));
        }
    }
}