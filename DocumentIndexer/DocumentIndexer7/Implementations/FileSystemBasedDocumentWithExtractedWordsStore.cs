using System.IO;
using System.IO.Abstractions;
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

            while(fileSystem.File.Exists(filePath))
            {
                filePath = baseFilePath + index;
                index++;
            }

            var serializer = new XmlSerializer(typeof(InputDocumentWithExtractedWords));

            using (var fs = fileSystem.File.OpenWrite(filePath))
            {
                serializer.Serialize(fs, inputDocumentWithExtractedWords);
            }

        }
    }
}