using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentIndexer.Interfaces;
using DocumentIndexer.Interfaces.DTOs;

namespace DocumentIndexer.Implementations
{
    public class RetryAwareDocumentWithExtractedWordsStore : IDocumentWithExtractedWordsStore
    {
        private readonly IDocumentWithExtractedWordsStore decorated;
        private readonly IRetryWaiter retryWaiter;
        private readonly int maximumRetries;

        public RetryAwareDocumentWithExtractedWordsStore(
            IDocumentWithExtractedWordsStore decorated, IRetryWaiter retryWaiter, int maximumRetries)
        {
            this.decorated = decorated;
            this.retryWaiter = retryWaiter;
            this.maximumRetries = maximumRetries;
        }

        public void Store(InputDocumentWithExtractedWords inputDocumentWithExtractedWords)
        {
            int retries = 0;

            while (true)
            {
                try
                {
                    decorated.Store(inputDocumentWithExtractedWords);
                    return;
                }
                catch
                {
                    if (retries >= maximumRetries)
                        throw;

                    retries++;

                    retryWaiter.WaitForRetry(retryNumber: retries);
                }
            }
        }
    }
}
