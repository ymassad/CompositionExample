using System.Diagnostics;

namespace DocumentIndexer.Interfaces
{
    public interface IEventLog
    {
        void WriteEntry(string message, EventLogEntryType type);
    }
}