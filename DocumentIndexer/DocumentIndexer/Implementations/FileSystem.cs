using System.IO;
using DocumentIndexer.Interfaces;

namespace DocumentIndexer.Implementations
{
    public class FileSystem : IFileSystem
    {
        public string[] GetFiles(string path)
        {
            return Directory.GetFiles(path);
        }

        public string ReadAllText(string file)
        {
            return File.ReadAllText(file);
        }

        public void MoveFile(string currentFullFilePath, string destinationFullFilePath)
        {
            File.Move(currentFullFilePath, destinationFullFilePath);
        }

        public void AppendAllText(string file, string text)
        {
            File.AppendAllText(file, text);
        }
    }
}