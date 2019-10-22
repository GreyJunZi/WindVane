using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WindVane.Domain.Entities;

namespace WindVane.Domain.Interfaces
{
    public interface IAsyncRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task AddAsync(TEntity entity);

        Task AddRangeAsync(IEnumerable<TEntity> entities);

        Task<TEntity> FindAsync(object Id);

        Task<int> CountAsync();

        Task<long> LongCountAsync();
    }
}
