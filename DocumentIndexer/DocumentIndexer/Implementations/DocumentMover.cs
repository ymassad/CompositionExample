using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentIndexer.Interfaces;
using DocumentIndexer.Interfaces.DTOs;

namespace DocumentIndexer.Implementations
{
    public class DocumentMover : IDocumentProcessor
    {
        private readonly string path;
        private readonly string destinationPath;
        private readonly IFileSystem fileSystem;

        public DocumentMover(
            string path,
            string destinationPath,
            IFileSystem fileSystem)
        {
            this.path = path;
            this.destinationPath = destinationPath;
            this.fileSystem = fileSystem;
        }

        public void Process(InputDocument inputDocument)
        {
            string currentFullFilePath = Path.Combine(path, inputDocument.DocumentName);

            string destinationFullFilePath = Path.Combine(destinationPath, inputDocument.DocumentName);

            fileSystem.MoveFile(currentFullFilePath, destinationFullFilePath);
        }
    }
}
