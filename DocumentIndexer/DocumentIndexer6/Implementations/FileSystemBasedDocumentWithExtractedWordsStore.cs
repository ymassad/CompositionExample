using System.IO;
using System.Xml.Serialization;
using DocumentIndexer.Interfaces;
using DocumentIndexer.Interfaces.DTOs;

namespace DocumentIndexer.Implementations
{
    public class FileSystemBasedDocumentWithExtractedWordsStore : IDocumentWithExtractedWordsStore
    {
        private readonly string outputFolderPath;

        public FileSystemBasedDocumentWithExtractedWordsStore(string outputFolderPath)
        {
            this.outputFolderPath = outputFolderPath;
        }

        public void Store(InputDocumentWithExtractedWords inputDocumentWithExtractedWords)
        {
            var baseFilePath =
                Path.Combine(outputFolderPath, inputDocumentWithExtractedWords.InputDocument.DocumentName);

            var filePath = baseFilePath;

            int index = 1;

            while(File.Exists(filePath))
            {
                filePath = baseFilePath + index;
                index++;
            }

            var serializer = new XmlSerializer(typeof(InputDocumentWithExtractedWords));

            using (var fs = File.OpenWrite(filePath))
            {
                serializer.Serialize(fs, inputDocumentWithExtractedWords);
            }

        }
    }
}