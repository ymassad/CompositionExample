using System;

namespace DocumentIndexer.Interfaces
{
    public interface IRestClient
    {
        string Post(Uri url, string body);
    }
}