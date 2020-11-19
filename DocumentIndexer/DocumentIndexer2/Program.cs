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

            var create =
                 CtorOf<DocumentGrabberAndProcessor>()
                    .Replace(documentsSource: CtorOf<FileSystemDocumentsSource>()
                        .Rename(path_documentsSourcePath :0))
                    .Replace(documentProcessor: CtorOf<IndexProcessor>())
                    .Replace(wordsExtractor: CtorOf<SimpleWordsExtractor>())
                    .Replace(documentWithExtractedWordsStore: CtorOf<DocumentWithExtractedWordsStore>());

            var runnable =
                create.Invoke(
                    documentsSourcePath: settings.FolderPath,
                    dataContextFactory: new DataContextFactory(settings.ConnectionString));

            runnable.Run();

            Console.WriteLine("Done. Press any key to exit");

            Console.ReadKey();
        }

        private static Settings ReadSettingsFromConfigurationFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));

            return (Settings)serializer.Deserialize(new MemoryStream(File.ReadAllBytes("Settings.xml")));
        }
    }
}