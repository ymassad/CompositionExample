using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DocumentIndexer.Configuration;
using DocumentIndexer.Implementations;

namespace DocumentIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = ReadSettingsFromConfigurationFile();

            var runnable =
                new DocumentGrabberAndProcessor(
                    documentsSource: CreateDocumentSource(settings),
                    documentProcessor: CreateDocumentProcessor(settings));

            runnable.Run();

            Console.WriteLine("Done. Press any key to exit");

            Console.ReadKey();
        }

        private static IndexProcessor CreateDocumentProcessor(Settings settings)
        {
            return new IndexProcessor(
                wordsExtractor:
                    new SimpleWordsExtractor(),
                documentWithExtractedWordsStore:
                    new DocumentWithExtractedWordsStore(
                        new DataContextFactory(settings.ConnectionString)));
        }

        private static FileSystemDocumentsSource CreateDocumentSource(Settings settings)
        {
            return new FileSystemDocumentsSource(settings.FolderPath);
        }

        private static Settings ReadSettingsFromConfigurationFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));

            return (Settings)serializer.Deserialize(new MemoryStream(File.ReadAllBytes("Settings.xml")));
        }
    }
}
