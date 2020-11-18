using System;
using System.Linq;
using DocumentIndexer.Interfaces;

namespace DocumentIndexer.Implementations
{
    public class SimpleWordsExtractor : IWordsExtractor
    {
        public string[] GetWords(string content)
        {
            return content
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToArray();
        }
    }
}