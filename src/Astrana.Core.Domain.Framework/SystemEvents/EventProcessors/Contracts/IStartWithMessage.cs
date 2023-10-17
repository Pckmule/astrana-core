using Astrana.Core.Framework.SystemEvents.MessageTypes;

namespace Astrana.Core.Framework.SystemEvents.EventProcessors.Contracts
{
    public interface IStartWithMessage<in TMessage> where TMessage : Message
    {
        void Handle(TMessage message);
    }
}