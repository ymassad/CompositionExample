namespace DocumentIndexer.Interfaces
{
    public interface IFileSystem
    {
        string[] GetFiles(string directoryPath);
        string ReadAllText(string filePath);
    }
}