using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nintek.Events.Handling
{
    public interface IUnitOfWork
    {
        Task Commit();
        event Action<IUnitOfWork> Commited;
    }
}
