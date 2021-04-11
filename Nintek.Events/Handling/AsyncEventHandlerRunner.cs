using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nintek.Events.Handling
{
    public delegate Task AsyncEventHandlerRunner(IDependencyScope scope, IEvent @event);
}
