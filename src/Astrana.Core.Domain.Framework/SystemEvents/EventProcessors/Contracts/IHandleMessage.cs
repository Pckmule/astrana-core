namespace Astrana.Core.Framework.SystemEvents.EventProcessors.Contracts;

public interface IHandleMessage<in TMessage>
{
    void Handle(TMessage message);
}