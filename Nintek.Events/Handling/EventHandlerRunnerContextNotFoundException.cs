using System;
using System.Collections.Generic;
using System.Text;

namespace Nintek.Events.Handling
{
    public class EventHandlerRunnerContextNotFoundException : Exception
    {
        public EventHandlerRunnerContextNotFoundException(string eventName, string handlerName)
            : base($"Could not find runner context for {eventName} -> {handlerName}.")
        {
        }
    }
}
