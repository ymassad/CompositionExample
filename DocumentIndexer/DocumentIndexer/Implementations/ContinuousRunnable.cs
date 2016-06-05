using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DocumentIndexer.Interfaces;

namespace DocumentIndexer.Implementations
{
    public class ContinuousRunnable : ICancellableRunnable
    {
        private readonly IRunnable runnable;
        private readonly TimeSpan waitTimeBetweenRuns;

        public ContinuousRunnable(IRunnable runnable, TimeSpan waitTimeBetweenRuns)
        {
            this.runnable = runnable;
            this.waitTimeBetweenRuns = waitTimeBetweenRuns;
        }

        public void Run(CancellationToken cancellationToken)
        {
            while (true)
            {
                runnable.Run();

                if (cancellationToken.IsCancellationRequested)
                    return;

                Thread.Sleep(waitTimeBetweenRuns);

                if (cancellationToken.IsCancellationRequested)
                    return;
            }
        }
    }
}
