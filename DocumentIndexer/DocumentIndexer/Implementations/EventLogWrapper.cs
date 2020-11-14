using System.Diagnostics;
using DocumentIndexer.Interfaces;

namespace DocumentIndexer.Implementations
{
    public class EventLogWrapper : IEventLog
    {
        private readonly EventLog eventLog;

        public EventLogWrapper(EventLog eventLog)
        {
            this.eventLog = eventLog;
        }

        public void WriteEntry(string message, EventLogEntryType type)
        {
            eventLog.WriteEntry(message, type);
        }
    }
}