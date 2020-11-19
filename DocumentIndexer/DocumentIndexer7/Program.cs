using System;
using System.Collections.Generic;
using System.IO;
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

            var createDocumentGrabber = CreateDocumentGrabberAndProcessor();

            var create1 =
                createDocumentGrabber
                    .Replace(wordsExtractor: CtorOf<SimpleWordsExtractor>())
                    .Replace(documentWithExtractedWordsStore: CtorOf<DocumentWithExtractedWordsStore>());

            var create2 =
                createDocumentGrabber
                    .Replace(wordsExtractor: CtorOf<RestBasedWordsExtractor>()
                                                 .Rename(url_extractorServiceUrl: 0))
                    .Replace(documentWithExtractedWordsStore:
                        CtorOf<FileSystemBasedDocumentWithExtractedWordsStore>());

            var create3 = CtorOf<CompositeRunnable>()
                .ReplaceOne(runnables: create1)
                .ReplaceLast(runnables: create2);

            var create4 = create3
                .JoinAllInputs();

            var runnable =
                create4.Invoke(
                    documentsSourcePath: settings.FolderPath,
                    dataContextIsolationFactory: new DataContextFactory(settings.ConnectionString),
                    extractorServiceUrl: "http://localhost",
                    outputFolderPath: settings.OutputFolderPath,
                    fileSystem: new FileSystem());

            runnable.Run();

            Console.WriteLine("Done. Press any key to exit");

            Console.ReadKey();
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