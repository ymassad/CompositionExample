using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentIndexer.Interfaces;

namespace DocumentIndexer.Implementations
{
    public class DocumentGrabberAndProcessor : IRunnable
    {
        private readonly IDocumentsSource documentsSource;
        private readonly IDocumentProcessor documentProcessor;

        public DocumentGrabberAndProcessor(IDocumentsSource documentsSource, IDocumentProcessor documentProcessor)
        {
            this.documentsSource = documentsSource;
            this.documentProcessor = documentProcessor;
        }

        public void Run()
        {
            foreach (var document in documentsSource.GetDocuments())
            {
                documentProcessor.Process(document);
            }
        }
    }
}
