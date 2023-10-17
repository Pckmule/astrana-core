namespace Astrana.Core.Framework.SystemEvents.EventStore.Models
{
    public class EventRecord
    {
        public int Id { get; set; }

        public string Action { get; set; }

        public int AggregateId { get; set; }

        public string Cargo { get; set; }

        public DateTime? TimeStamp { get; set; }
    }
}
