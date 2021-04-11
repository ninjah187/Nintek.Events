using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nintek.Events.Handling
{
    public interface IEventRepository
    {
        Task Add(EventualConsistentEvent eventualConsistent);
        Task<EventualConsistentEvent[]> GetAllProcessables();
        Task Remove(IEvent @event);
        Task<EventualConsistentEvent[]> Take(int count = 1);
        Task Update(EventualConsistentEvent eventualConsistent);
    }
}
