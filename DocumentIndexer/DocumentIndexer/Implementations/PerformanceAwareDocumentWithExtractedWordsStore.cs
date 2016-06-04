using System.Diagnostics;
using DocumentIndexer.Interfaces;
using DocumentIndexer.Interfaces.DTOs;

namespace DocumentIndexer.Implementations
{
    public class PerformanceAwareDocumentWithExtractedWordsStore : IDocumentWithExtractedWordsStore
    {
        private readonly IDocumentWithExtractedWordsStore decorated;
        private readonly IPerformanceRecorder performanceRecorder;

        public PerformanceAwareDocumentWithExtractedWordsStore(
            IDocumentWithExtractedWordsStore decorated,
            IPerformanceRecorder performanceRecorder)
        {
            this.decorated = decorated;
            this.performanceRecorder = performanceRecorder;
        }

        public void Store(InputDocumentWithExtractedWords inputDocumentWithExtractedWords)
        {
            Stopwatch sw = Stopwatch.StartNew();

            decorated.Store(inputDocumentWithExtractedWords);

            var elapsed = sw.Elapsed;

            performanceRecorder.RecordInstance(elapsed);
        }
    }
}