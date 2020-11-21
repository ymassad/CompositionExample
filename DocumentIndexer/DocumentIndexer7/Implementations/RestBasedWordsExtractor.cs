using System;
using System.Linq;
using DocumentIndexer.Interfaces;
using Newtonsoft.Json;

namespace DocumentIndexer.Implementations
{
    public class RestBasedWordsExtractor : IWordsExtractor
    {
        private readonly Uri url;
        private readonly IRestClient restClient;

        public RestBasedWordsExtractor(Uri url, IRestClient restClient)
        {
            this.url = url;
            this.restClient = restClient;
        }

        public string[] GetWords(string content)
        {
            var actionUrl = new Uri(url, "/GetWords");

            return JsonConvert.DeserializeObject<string[]>(restClient.Post(actionUrl, content));
        }
    }
}