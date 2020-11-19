﻿using System;
using System.Linq;
using DocumentIndexer.Interfaces;

namespace DocumentIndexer.Implementations
{
    public class RestBasedWordsExtractor : IWordsExtractor
    {
        private readonly string url;

        public RestBasedWordsExtractor(string url)
        {
            this.url = url;
        }

        public string[] GetWords(string content)
        {
            //TODO: create a REST client and call API to get the words from the content
            return content
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToArray();
        }
    }
}