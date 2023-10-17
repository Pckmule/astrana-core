using Astrana.Core.Framework.SystemEvents.EventProcessors;
using Astrana.Core.Framework.SystemEvents.MessageTypes;

namespace Astrana.Core.Framework.SystemEvents.EventBus
{
    public interface IEventBus
    {
        void Send<TCommand>(TCommand command) where TCommand : Command;

        void RaiseEvent<TEvent>(TEvent theEvent) where TEvent : Event;

        void RegisterSaga<TSaga>() where TSaga : SagaBase;

        void RegisterHandler<THandler>();
    }
}