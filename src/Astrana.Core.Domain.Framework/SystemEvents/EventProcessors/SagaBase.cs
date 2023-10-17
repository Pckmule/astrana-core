using Astrana.Core.Framework.SystemEvents.EventBus;
using Astrana.Core.Framework.SystemEvents.EventStore.Contracts;

namespace Astrana.Core.Framework.SystemEvents.EventProcessors
{
    /// <summary>
    /// Sagas are event handlers that are typically process data and/or are long running.
    /// </summary>
    public abstract class SagaBase
    {
        public IEventBus EventBus { get; private set; }

        public IEventStore EventStore { get; private set; }

        protected SagaBase(IEventBus eventBus, IEventStore eventStore)
        {
            if (eventBus == null)
                throw new ArgumentNullException(nameof(eventBus));

            if (eventStore == null)
                throw new ArgumentNullException(nameof(eventStore));

            EventBus = eventBus;
            EventStore = eventStore;
        }
    }

}