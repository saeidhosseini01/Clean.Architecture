using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Interface
{
    public interface IUnitOfWork
    {
        Task SaveChange(CancellationToken cancellationToken);
    }

}
