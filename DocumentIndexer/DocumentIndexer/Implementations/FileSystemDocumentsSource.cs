using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentIndexer.Interfaces;
using DocumentIndexer.Interfaces.DTOs;

namespace DocumentIndexer.Implementations
{
    public class FileSystemDocumentsSource : IDocumentsSource
    {
        private readonly string path;
        private readonly IFileSystem fileSystem;
        public FileSystemDocumentsSource(string path, IFileSystem fileSystem)
        {
            this.path = path;
            this.fileSystem = fileSystem;
        }

        public InputDocument[] GetDocuments()
        {
            return
                fileSystem.GetFiles(path)
                    .Select(file =>
                        new InputDocument(
                            documentName: Path.GetFileName(file),
                            documentContent: fileSystem.ReadAllText(file)))
                    .ToArray();
        }
    }
}
