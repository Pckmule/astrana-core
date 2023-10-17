using Astrana.Core.Framework.SystemEvents.MessageTypes;

namespace Astrana.Infrastructure
{
    public abstract class Aggregate : IAggregate
    {
        public Guid Id { get; protected set; }

        private readonly IList<Event> _uncommittedEvents = new List<Event>();

        Guid IAggregate.Id => Id;

        bool IAggregate.HasPendingChanges => _uncommittedEvents.Any();

        IEnumerable<Event> IAggregate.GetUncommittedEvents()
        {
            return _uncommittedEvents.ToArray();
        }

        void IAggregate.ClearUncommittedEvents()
        {
            _uncommittedEvents.Clear();
        }

        protected void RaiseEvent(Event @event)
        {
            _uncommittedEvents.Add(@event);

            (this as dynamic).Apply((dynamic)@event);
        }
    }

}