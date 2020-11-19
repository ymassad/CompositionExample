namespace DocumentIndexer.Interfaces
{
    public interface IWordsExtractor
    {
        string[] GetWords(string content);
    }
}