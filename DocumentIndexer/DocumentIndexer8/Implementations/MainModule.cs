using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentIndexer.Interfaces;
using DocumentIndexer.Interfaces.DTOs;

namespace DocumentIndexer.Implementations
{
    public static class MainModule
    {
        public static void RunMultiple(Action[] runnables)
        {
            foreach (var runnable in runnables)
                runnable();
        }

        public static void GrabAndProcessorDocuments(Func<InputDocument[]> getDocuments, Action<InputDocument> processDocument)
        {
            foreach (var document in getDocuments())
            {
                processDocument(document);
            }
        }

        public static void IndexDocument(
            Func<string /*documentContent*/, string[]> extractWords,
            Action<InputDocumentWithExtractedWords> storeDocumentWithExtractedWords,
            InputDocument inputDocument)
        {
            string[] words = extractWords(inputDocument.DocumentContent);

            storeDocumentWithExtractedWords(
                new InputDocumentWithExtractedWords
                {
                    InputDocument = inputDocument,
                    ExtractedWords = words
                });
        }

        public static string[] GetWords(string content)
        {
            return content
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToArray();
        }
    }
}
