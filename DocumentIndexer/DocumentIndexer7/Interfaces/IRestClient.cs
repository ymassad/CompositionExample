namespace DocumentIndexer.Interfaces
{
    public interface IRestClient
    {
        string Post(string url, string body);
    }
}