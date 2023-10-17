using Astrana.Core.Framework.SystemEvents.EventBus;
using Astrana.Core.Framework.SystemEvents.EventProcessors.Contracts;
using Astrana.Core.Framework.SystemEvents.EventStore.Contracts;
using Astrana.Core.Framework.SystemEvents.MessageTypes;

namespace Astrana.Infrastructure.EventBus
{
    public class InMemoryEventBus : IEventBus
    {
        public IEventStore EventStore { get; private set; }

        private static readonly IDictionary<Type, Type> RegisteredSagas = new Dictionary<Type, Type>();
        private static readonly IList<Type> RegisteredHandlers = new List<Type>();

        public InMemoryEventBus(IEventStore eventStore)
        {
            if (eventStore == null)
                throw new ArgumentNullException(nameof(eventStore));

            EventStore = eventStore;
        }

        void IEventBus.RegisterSaga<TSaga>()
        {
            var sagaType = typeof(TSaga);
            
            if (sagaType.GetInterfaces().Count(i => i.Name.StartsWith(typeof(IStartWithMessage<>).Name)) != 1)
                throw new InvalidOperationException("The specified saga must implement the IStartWithMessage<T> interface.");
            
            var messageType = sagaType.
                GetInterfaces().First(i => i.Name.StartsWith(typeof(IStartWithMessage<>).Name)).
                GenericTypeArguments.
                First();

            RegisteredSagas.Add(messageType, sagaType);
        }

        void IEventBus.RegisterHandler<THandler>()
        {
            RegisteredHandlers.Add(typeof(THandler));
        }

        void IEventBus.Send<TMessage>(TMessage message)
        {
            SendInternal(message);
        }

        void IEventBus.RaiseEvent<TEvent>(TEvent eventToRaise)
        {
            if (EventStore != null)
                EventStore.Save(eventToRaise);

            SendInternal(eventToRaise);
        }
        
        private void SendInternal<TMessage>(TMessage message) where TMessage : Message
        {
            LaunchSagasThatStartWithMessage(message);
            DeliverMessageToRunningSagas(message);
            DeliverMessageToRegisteredHandlers(message);

            // Saga and handlers are similar things. Handlers are one-off event handlers
            // whereas saga may be persisted and survive sessions, wait for more messages and so forth.
            // Saga are mostly complex workflows; handlers are plain one-off event handlers.
        }

        private void LaunchSagasThatStartWithMessage<TMessage>(TMessage message) where TMessage : Message
        {
            var messageType = message.GetType();

            var openInterface = typeof(IStartWithMessage<>);
            var closedInterface = openInterface.MakeGenericType(messageType);

            var sagasToLaunch = from sagas in RegisteredSagas.Values
                                where closedInterface.IsAssignableFrom(sagas)
                                select sagas;

            foreach (var sagaType in sagasToLaunch)
            {
                dynamic sagaInstance = Activator.CreateInstance(sagaType, this, EventStore)!;

                sagaInstance!.Handle(message);
            }
        }

        private void DeliverMessageToRunningSagas<TMessage>(TMessage message) where TMessage : Message
        {
            var messageType = message.GetType();

            var openInterface = typeof(IHandleMessage<>);
            var closedInterface = openInterface.MakeGenericType(messageType);

            var sagasToNotify = from sagas in RegisteredSagas.Values
                                where closedInterface.IsAssignableFrom(sagas)
                                select sagas;

            foreach (var sagaType in sagasToNotify)
            {
                dynamic sagaInstance = Activator.CreateInstance(sagaType, this, EventStore);

                sagaInstance.Handle(message);
            }
        }

        private void DeliverMessageToRegisteredHandlers<TMessage>(TMessage message) where TMessage : Message
        {
            var messageType = message.GetType();

            var openInterface = typeof(IHandleMessage<>);
            var closedInterface = openInterface.MakeGenericType(messageType);

            var handlersToNotify = from handlers in RegisteredHandlers
                                   where closedInterface.IsAssignableFrom(handlers)
                                   select handlers;

            foreach (var handlerType in handlersToNotify)
            {
                dynamic handlerInstance = Activator.CreateInstance(handlerType, EventStore);

                handlerInstance.Handle(message);
            }
        }
    }
}