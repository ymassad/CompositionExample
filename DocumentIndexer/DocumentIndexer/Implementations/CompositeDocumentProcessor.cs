using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentIndexer.Interfaces;
using DocumentIndexer.Interfaces.DTOs;

namespace DocumentIndexer.Implementations
{
    public class CompositeDocumentProcessor : IDocumentProcessor
    {
        private readonly IDocumentProcessor[] processors;

        public CompositeDocumentProcessor(params IDocumentProcessor[] processors)
        {
            this.processors = processors;
        }

        public void Process(InputDocument inputDocument)
        {
            foreach (var processor in processors)
                processor.Process(inputDocument);
        }
    }
}
