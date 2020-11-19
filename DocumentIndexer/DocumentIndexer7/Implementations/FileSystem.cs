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

        public bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        public Stream OpenFileForWrite(string filePath)
        {
            return File.OpenWrite(filePath);
        }
    }
}