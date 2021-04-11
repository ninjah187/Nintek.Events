using System;
using System.Collections.Generic;
using System.Text;

namespace Nintek.Events.Handling
{
    public class EventData
    {
        public EventData(
            string id,
            string eventName,
            string handlerName,
            EventualConsistentState state,
            int processAttempts,
            string payload)
        {
            Id = id;
            EventName = eventName;
            HandlerName = handlerName;
            State = state;
            ProcessAttempts = processAttempts;
            Payload = payload;
        }

        public string Id { get; set; }
        public string EventName { get; set; }
        public string HandlerName { get; set; }
        public EventualConsistentState State { get; set; }
        public int ProcessAttempts { get; set; }
        public string Payload { get; set; }
    }
}
