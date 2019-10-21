using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WindVane.Domain.Interfaces
{
    public interface IAsyncRepository<TEntity> : IDisposable where TEntity : IEntity
    {
        Task AddAsync(TEntity entity);

        Task AddRangeAsync(IEnumerable<TEntity> entities);

        Task<TEntity> FindAsync(object Id);

        Task<int> CountAsync();

        Task<long> LongCountAsync();
    }
}
