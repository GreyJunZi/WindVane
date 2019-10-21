using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WindVane.Data.Context;
using WindVane.Domain.Interfaces;

namespace WindVane.Data.Repository
{
    public class AsyncRepository<TEntity> : IAsyncRepository<TEntity> where TEntity : IEntity
    {
        protected WindVaneContext _dbContext { get; }
        protected DbSet<TEntity> _dbSet { get; }

        public AsyncRepository(WindVaneContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync();
        }

        public async Task<TEntity> FindAsync(object Id)
        {
            return await _dbSet.FindAsync(Id);
        }

        public async Task<int> CountAsync()
        {
            return await _dbSet.CountAsync();
        }

        public async Task<long> LongCountAsync()
        {
            return await _dbSet.LongCountAsync();
        }

        public async Task Dispose()
        {
            await _dbContext.DisposeAsync();
            GC.SuppressFinalize(this);
        }
    }
}
