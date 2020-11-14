namespace DocumentIndexer.Interfaces
{
    public interface IFileSystem
    {
        string[] GetFiles(string path);
        string ReadAllText(string file);
        void MoveFile(string currentFullFilePath, string destinationFullFilePath);
        void AppendAllText(string file, string text);
    }
}