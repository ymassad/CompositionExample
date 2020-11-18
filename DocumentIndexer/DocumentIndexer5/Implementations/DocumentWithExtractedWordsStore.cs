using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentIndexer.Data;
using DocumentIndexer.Interfaces;
using DocumentIndexer.Interfaces.DTOs;

namespace DocumentIndexer.Implementations
{
    public class DocumentWithExtractedWordsStore : IDocumentWithExtractedWordsStore
    {
        private readonly IDataContextFactory dataContextIsolationFactory;

        public DocumentWithExtractedWordsStore(IDataContextFactory dataContextIsolationFactory)
        {
            this.dataContextIsolationFactory = dataContextIsolationFactory;
        }

        public void Store(InputDocumentWithExtractedWords inputDocumentWithExtractedWords)
        {
            using (var context = dataContextIsolationFactory.Create())
            {
                var inputDocument = inputDocumentWithExtractedWords.InputDocument;

                var document = new Document
                {
                    Content = inputDocument.DocumentContent,
                    Name = inputDocument.DocumentName
                };

                context.Documents.Add(document);

                context.IndexEntries
                    .AddRange(
                        inputDocumentWithExtractedWords
                        .ExtractedWords
                        .Select(word => new IndexEntry
                        {
                            Document = document,
                            Word = word
                        }));

                context.SaveChanges();
            }
        }
    }
}
