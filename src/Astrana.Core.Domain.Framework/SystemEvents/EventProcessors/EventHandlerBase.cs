using Astrana.Core.Framework.SystemEvents.EventStore.Contracts;

namespace Astrana.Core.Framework.SystemEvents.EventProcessors
{
    public abstract class EventHandlerBase
    {
        public IEventStore EventStore { get; private set; }

        public EventHandlerBase(IEventStore eventStore)
        {
            EventStore = eventStore ?? throw new ArgumentNullException(nameof(eventStore));
        }
    }

}