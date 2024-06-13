using Clean.Architecture.Application.Interface;
using Clean.Architecture.Domain.Common.Entitis;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Infrastructure.Persistence.Services
{
    public class BaseRepository<T> :IUnitOfWork, IBaseRepository<T> where T : BaseEntity
    {
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByGuidAsync(Guid guid, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SaveChange(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
