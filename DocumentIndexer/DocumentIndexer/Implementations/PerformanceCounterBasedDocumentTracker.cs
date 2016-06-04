using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentIndexer.Interfaces;
using DocumentIndexer.Interfaces.DTOs;

namespace DocumentIndexer.Implementations
{
    public class PerformanceCounterBasedDocumentTracker : IDocumentProcessor
    {
        private readonly PerformanceCounter performanceCounter;

        public PerformanceCounterBasedDocumentTracker(PerformanceCounter performanceCounter)
        {
            this.performanceCounter = performanceCounter;
        }

        public void Process(InputDocument inputDocument)
        {
            performanceCounter.Increment();
        }
    }
}
