using System;
using System.Linq;
using Newtonsoft.Json;

namespace DocumentIndexer.Implementations
{
    public static class RestModule
    {
        public static string[] GetWordsUsingRestService(
            string url,
            Func<string /*url*/, string /*body*/, string> post,
            string content)
        {
            var actionUrl = url + "/GetWords";

            return JsonConvert.DeserializeObject<string[]>(post(actionUrl, content));
        }


        public static string Post(string url, string body)
        {
            /*
            Because this is a sample application, I don't want to do a real HTTP post here.
            A real implementation would do something like this:
            
            HttpClient client = new HttpClient(); //TODO: don't create a new client per request

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