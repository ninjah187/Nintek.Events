using System;
using System.Collections.Generic;
using System.Text;

namespace Nintek.Events
{
    public abstract class Event : IEvent
    {
        public string Id { get; private set; }

        protected Event()
        {
            Id = Guid.NewGuid().ToString();
        }

        protected Event(string id)
        {
            Id = id;
        }
    }
}
