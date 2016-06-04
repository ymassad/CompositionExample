using System.Collections.Generic;
using System.Linq;
using DocumentIndexer.Interfaces;
using DocumentIndexer.Interfaces.DTOs;

namespace DocumentIndexer.Implementations
{
    public class ProcessedDocumentsAwareDocumentsSource : IDocumentsSource
    {
        private readonly IDocumentsSource decoratedDocumentsSource;
        private readonly IDataContextFactory dataContextFactory;

        public ProcessedDocumentsAwareDocumentsSource(
            IDocumentsSource decoratedDocumentsSource,
            IDataContextFactory dataContextFactory)
        {
            this.decoratedDocumentsSource = decoratedDocumentsSource;
            this.dataContextFactory = dataContextFactory;
        }

        public InputDocument[] GetDocuments()
        {
            var allDocuments = decoratedDocumentsSource.GetDocuments();

            HashSet<string> processedDocuments;

            using (var context = dataContextFactory.Create())
            {
                processedDocuments = new HashSet<string>(context.Documents.Select(x => x.Name));
            }

            return allDocuments.Where(x => !processedDocuments.Contains(x.DocumentName)).ToArray();
        }
    }
}