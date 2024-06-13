using Clean.Architecture.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Infrastructure.Persistence.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        public Task SaveChange(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
