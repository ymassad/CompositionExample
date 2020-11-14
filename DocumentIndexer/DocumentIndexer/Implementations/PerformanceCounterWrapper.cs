using System.Diagnostics;
using DocumentIndexer.Interfaces;

namespace DocumentIndexer.Implementations
{
    public class PerformanceCounterWrapper : IPerformanceCounter
    {
        private readonly PerformanceCounter performanceCounter;

        public PerformanceCounterWrapper(PerformanceCounter performanceCounter)
        {
            this.performanceCounter = performanceCounter;
        }

        public long Increment()
        {
            return performanceCounter.Increment();
        }

        public long IncrementBy(long value)
        {
            return performanceCounter.IncrementBy(value);
        }
    }
}