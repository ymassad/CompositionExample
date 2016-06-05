using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DocumentIndexer.Interfaces;

namespace DocumentIndexer.Implementations
{
    public class IncrementalTimeRetryWaiter : IRetryWaiter
    {
        private readonly TimeSpan baseWaitTime;

        public IncrementalTimeRetryWaiter(TimeSpan baseWaitTime)
        {
            this.baseWaitTime = baseWaitTime;
        }

        public void WaitForRetry(int retryNumber)
        {
            var waitTime = new TimeSpan(baseWaitTime.Ticks * retryNumber);

            Thread.Sleep(waitTime);
        }
    }
}
