using System;
using System.IO;
using System.IO.Abstractions;
using System.Linq;
using System.Xml.Serialization;
using DocumentIndexer.Data;
using DocumentIndexer.Interfaces.DTOs;

namespace DocumentIndexer.Implementations
{
    public static class StorageModule
    {
        public static void StoreToTheDatabase(Func<DataContext> createDataContext, InputDocumentWithExtractedWords inputDocumentWithExtractedWords)
        {
            using (var context = createDataContext())
            {
                var inputDocument = inputDocumentWithExtractedWords.InputDocument;

                var document = new Document
                {
                    Content = inputDocument.DocumentContent,
                    Name = inputDocument.DocumentName
                };

                context.Documents.Add(document);

                context.IndexEntries
                    .AddRange(
                        inputDocumentWithExtractedWords
                            .ExtractedWords
                            .Select(word => new IndexEntry
                            {
                                Document = document,
                                Word = word
                            }));

                context.SaveChanges();
            }
        }

        public static void StoreToTheFileSystem(string outputFolderPath, IFileSystem fileSystem, InputDocumentWithExtractedWords inputDocumentWithExtractedWords)
        {
            var baseFilePath =
                Path.Combine(outputFolderPath, inputDocumentWithExtractedWords.InputDocument.DocumentName);

            var filePath = baseFilePath;

            int index = 1;

            while (fileSystem.File.Exists(filePath))
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

        public static DataContext CreateDatabaseContext(string connectionString)
        {
            return new DataContext(connectionString);
        }

        public static InputDocument[] GetDocumentsFromFileSystem(string path, IFileSystem fileSystem)
        {
            return
                fileSystem.Directory.GetFiles(path)
                    .Select(file =>
                        new InputDocument
                        {
                            DocumentName = Path.GetFileName(file),
                            DocumentContent = fileSystem.File.ReadAllText(file)
                        })
                    .ToArray();
        }


    }
}