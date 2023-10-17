namespace Astrana.Core.Framework.SystemEvents.MessageTypes
{
    public class Event : Message
    {
        public DateTime TimeStamp { get; private set; }

        public Event()
        {
            TimeStamp = DateTime.UtcNow;
            Name = GetType().Name;
        }
    }
}