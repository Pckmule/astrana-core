using Astrana.Core.Framework.SystemEvents.MessageTypes;

namespace Astrana.Infrastructure
{
    public interface IAggregate
    {
        Guid Id { get; }

        bool HasPendingChanges { get; }

        IEnumerable<Event> GetUncommittedEvents();

        void ClearUncommittedEvents();
    }
}