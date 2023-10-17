using Astrana.Core.Framework.SystemEvents.EventStore.Models;

namespace Astrana.Core.Domain.Framework.Repositories
{
    public class EventRepository
    {
        // private readonly MerloEventStore _db = new MerloEventStore();

        public void Store(EventRecord eventRecordToLog)
        {
            eventRecordToLog.TimeStamp = DateTime.Now;
            // _db.LoggedEvents.Add(eventRecordToLog);
            // _db.SaveChanges();
        }
    }
}