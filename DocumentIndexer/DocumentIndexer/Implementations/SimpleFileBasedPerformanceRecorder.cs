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
        private readonly IFileSystem fileSystem;

        public SimpleFileBasedPerformanceRecorder(string file, IFileSystem fileSystem)
        {
            this.file = file;
            this.fileSystem = fileSystem;
        }

        public void RecordInstance(TimeSpan elapsed)
        {
            fileSystem.AppendAllText(file, elapsed.TotalMilliseconds + "ms" + Environment.NewLine);
        }
    }
}
