using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentIndexer.Interfaces;
using DocumentIndexer.Interfaces.DTOs;

namespace DocumentIndexer.Implementations
{
    public class IndexProcessor : IDocumentProcessor
    {
        private readonly IWordsExtractor wordsExtractor;
        private readonly IDocumentWithExtractedWordsStore documentWithExtractedWordsStore;

        public IndexProcessor(
            IWordsExtractor wordsExtractor,
            IDocumentWithExtractedWordsStore documentWithExtractedWordsStore)
        {
            this.wordsExtractor = wordsExtractor;
            this.documentWithExtractedWordsStore = documentWithExtractedWordsStore;
        }

        public void Process(InputDocument inputDocument)
        {
            string[] words = wordsExtractor.GetWords(inputDocument.DocumentContent);

            documentWithExtractedWordsStore.Store(
                new InputDocumentWithExtractedWords
                {
                    InputDocument = inputDocument,
                    ExtractedWords = words
                });
        }
    }
}
