using System.IO;
using System.Xml.Serialization;
using DocumentIndexer.Interfaces;
using DocumentIndexer.Interfaces.DTOs;

namespace DocumentIndexer.Implementations
{
    public class FileSystemBasedDocumentWithExtractedWordsStore : IDocumentWithExtractedWordsStore
    {
        private readonly string outputFolderPath;
        private readonly IFileSystem fileSystem;

        public FileSystemBasedDocumentWithExtractedWordsStore(string outputFolderPath, IFileSystem fileSystem)
        {
            this.outputFolderPath = outputFolderPath;
            this.fileSystem = fileSystem;
        }

        public void Store(InputDocumentWithExtractedWords inputDocumentWithExtractedWords)
        {
            var baseFilePath =
                Path.Combine(outputFolderPath, inputDocumentWithExtractedWords.InputDocument.DocumentName);

            var filePath = baseFilePath;

            int index = 1;

            while(fileSystem.FileExists(filePath))
            {
                filePath = baseFilePath + index;
                index++;
            }

            var serializer = new XmlSerializer(typeof(InputDocumentWithExtractedWords));

            using (var fs = fileSystem.OpenFileForWrite(filePath))
            {
                serializer.Serialize(fs, inputDocumentWithExtractedWords);
            }

        }
    }
}