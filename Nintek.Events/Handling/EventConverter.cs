using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nintek.Events.Handling
{
    public interface IEventConverter
    {
        string Convert(IEvent @event);
        Task<IEvent> ConvertBack(string eventId, string serializedPayload);
    }

    public abstract class EventConverter : IEventConverter
    {
        public abstract string Convert(IEvent @event);
        public abstract Task<IEvent> ConvertBack(string eventId, string serializedPayload);
    }

    public abstract class EventConverter<TEvent> : EventConverter
        where TEvent : IEvent
    {
        public abstract string Serialize(TEvent @event);
        public abstract Task<TEvent> Deserialize(string eventId, string serializedPayload);

        public override sealed string Convert(IEvent @event)
        {
            return Serialize((TEvent)@event);
        }

        public override sealed async Task<IEvent> ConvertBack(string eventId, string serializedPayload)
        {
            return await Deserialize(eventId, serializedPayload);
        }
    }
}
