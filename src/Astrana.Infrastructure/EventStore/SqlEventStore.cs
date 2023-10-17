using Astrana.Core.Domain.Framework.Repositories;
using Astrana.Core.Framework.SystemEvents.EventStore.Contracts;
using Astrana.Core.Framework.SystemEvents.EventStore.Models;
using Astrana.Core.Framework.SystemEvents.MessageTypes;
using System.Text.Json;

namespace Astrana.Infrastructure.EventStore
{
    public class SqlEventStore : IEventStore
    {
        private static readonly EventRepository EventRepository = new();

        public IEnumerable<Event> All(string matchId)
        {
            return null; //EventRepository.All(matchId);
        }

        public void Save<TEvent>(TEvent eventToRecord) where TEvent : Event
        {
            var eventRecord = new EventRecord
            {
                Action = eventToRecord.Name,
                Cargo = JsonSerializer.Serialize(eventToRecord, new JsonSerializerOptions { WriteIndented = false })
            };

            EventRepository.Store(eventRecord);
        }
    }
}