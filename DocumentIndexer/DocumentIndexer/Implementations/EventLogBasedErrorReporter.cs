using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentIndexer.Interfaces;

namespace DocumentIndexer.Implementations
{
    public class EventLogBasedErrorReporter : IErrorReporter
    {
        private readonly IEventLog eventLog;

        public EventLogBasedErrorReporter(IEventLog eventLog)
        {
            this.eventLog = eventLog;
        }

        public void ReportError(Exception exception)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("An error has occurred.");
            sb.AppendLine("Message:");
            sb.AppendLine(exception.Message);

            eventLog.WriteEntry(sb.ToString(), EventLogEntryType.Error);
        }
    }
}
