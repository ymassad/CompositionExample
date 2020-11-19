using System.IO;
using DocumentIndexer.Interfaces;

namespace DocumentIndexer.Implementations
{
    public class FileSystem : IFileSystem
    {
        public string[] GetFiles(string directoryPath)
        {
            return Directory.GetFiles(directoryPath);
        }

        public string ReadAllText(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}