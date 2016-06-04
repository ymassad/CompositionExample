using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentIndexer.Interfaces;

namespace DocumentIndexer.Implementations
{
    public class SimpleFileBasedPerformanceRecorder : IPerformanceRecorder
    {
        private readonly string file;

        public SimpleFileBasedPerformanceRecorder(string file)
        {
            this.file = file;
        }

        public void RecordInstance(TimeSpan elapsed)
        {
            File.AppendAllText(file, elapsed.TotalMilliseconds + "ms" + Environment.NewLine);
        }
    }
}
