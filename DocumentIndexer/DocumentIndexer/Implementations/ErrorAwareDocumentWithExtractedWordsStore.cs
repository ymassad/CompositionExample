using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentIndexer.Interfaces;
using DocumentIndexer.Interfaces.DTOs;

namespace DocumentIndexer.Implementations
{
    public class ErrorAwareDocumentWithExtractedWordsStore : IDocumentWithExtractedWordsStore
    {
        private readonly IDocumentWithExtractedWordsStore decorated;
        private readonly IErrorReporter errorReporter;

        public ErrorAwareDocumentWithExtractedWordsStore(IDocumentWithExtractedWordsStore decorated, IErrorReporter errorReporter)
        {
            this.decorated = decorated;
            this.errorReporter = errorReporter;
        }

        public void Store(InputDocumentWithExtractedWords inputDocumentWithExtractedWords)
        {
            try
            {
                decorated.Store(inputDocumentWithExtractedWords);
            }
            catch (Exception ex)
            {
                errorReporter.ReportError(exception: ex);
                throw;
            }
        }
    }
}
