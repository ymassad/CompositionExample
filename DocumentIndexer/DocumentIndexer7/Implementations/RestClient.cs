using System;
using System.Linq;
using System.Net.Http;
using DocumentIndexer.Interfaces;
using Newtonsoft.Json;

namespace DocumentIndexer.Implementations
{
    public class RestClient : IRestClient
    {
        //HttpClient client = new HttpClient();
        public string Post(Uri url, string body)
        {
            /*
            Because this is a sample application, I don't want to do a real HTTP post here.
            A real implementation would do something like this:
            
            var response = client.PostAsync(url, new StringContent(body)).Result; //TODO: async all the way
            response.EnsureSuccessStatusCode();

            return response.Content.ReadAsStringAsync().Result; //TODO: async all the way
            */

            var result = body
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToArray();

            return JsonConvert.SerializeObject(result);
        }
    }
}