using Astrana.Core.Framework.SystemEvents.MessageTypes;

namespace Astrana.Core.Framework.SystemEvents.EventStore.Contracts
{
    public interface IEventStore
    {
        //IEnumerable<T> Find<T>(Func<T, bool> filter);
        //IEnumerable<MatchEvent> All(string matchId);

        void Save<T>(T eventToRecord) where T : Event;
    }
}