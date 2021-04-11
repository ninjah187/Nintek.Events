using System;
using System.Collections.Generic;
using System.Text;

namespace Nintek.Events
{
    public interface IEventEmitter
    {
        EventQueue Events { get; }
    }
}
