using System.Collections.Generic;
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

        public FileSystemDocumentsSource(string path)
        {
            this.path = path;
        }

        public InputDocument[] GetDocuments()
        {
            return
                Directory.GetFiles(path)
                    .Select(file =>
                        new InputDocument
                        {
                            DocumentName = Path.GetFileName(file),
                            DocumentContent = File.ReadAllText(file)
                        })
                    .ToArray();
        }
    }
}
