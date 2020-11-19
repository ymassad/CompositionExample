using System.IO;

namespace DocumentIndexer.Interfaces
{
    public interface IFileSystem
    {
        string[] GetFiles(string directoryPath);
        string ReadAllText(string filePath);
        bool FileExists(string filePath);
        Stream OpenFileForWrite(string filePath);
    }
}