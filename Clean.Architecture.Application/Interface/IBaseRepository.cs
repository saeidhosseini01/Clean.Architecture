using Clean.Architecture.Domain.Common.Entitis;

namespace Clean.Architecture.Application.Interface
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> GetByGuidAsync(Guid guid, CancellationToken cancellationToken);
        Task<List<T>> GetAllAsync(CancellationToken cancellationToken);
    }

}
