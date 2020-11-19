using System;
using System.Linq;
using DocumentIndexer.Interfaces;

namespace DocumentIndexer.Implementations
{
    public class RestBasedWordsExtractor : IWordsExtractor
    {
        private readonly string url;
        private readonly IRestClient restClient;

        public RestBasedWordsExtractor(string url, IRestClient restClient)
        {
            this.url = url;
            this.restClient = restClient;
        }

        public string[] GetWords(string content)
        {
            //TODO: create a REST client and call API to get the words from the content
            //string actionUrl = url + "/GetWords";

            //var result = restClient.Post(actionUrl, "{Content = \"" + content + "\"}");

            return content
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToArray();
        }
    }
}