using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentIndexer.Interfaces;

namespace DocumentIndexer.Implementations
{
    //This perforamnce recorder will record using two performance counters
    //One is of type RawFraction and another one is of type RawBase
    //The purpose is to be able to read the average time since the beginning.
    //The RawFraction counter is not really intended for this
    //but this is something that works.
    //We increment the first counter by the number of milliseconds
    //and the second one by 100
    //The reason why is beyond the scope of this example
    public class AveragePerformanceCounterBasedTimeRecorder : IPerformanceRecorder
    {
        private readonly PerformanceCounter rawFractionPerformanceCounter;
        private readonly PerformanceCounter rawBasePerformanceCounter;

        public AveragePerformanceCounterBasedTimeRecorder(
            PerformanceCounter rawFractionPerformanceCounter,
            PerformanceCounter rawBasePerformanceCounter)
        {
            this.rawFractionPerformanceCounter = rawFractionPerformanceCounter;
            this.rawBasePerformanceCounter = rawBasePerformanceCounter;
        }

        public void RecordInstance(TimeSpan elapsed)
        {
            rawFractionPerformanceCounter.IncrementBy((long)elapsed.TotalMilliseconds);
            rawBasePerformanceCounter.IncrementBy(100);
        }
    }
}
