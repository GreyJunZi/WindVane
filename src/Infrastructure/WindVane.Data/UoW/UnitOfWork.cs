using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WindVane.Data.Context;
using WindVane.Domain.Interfaces;

namespace WindVane.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WindVaneDbContext _dbContext;

        public UnitOfWork(WindVaneDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Commit()
        {
            return _dbContext.SaveChanges() > 0;
        }

        public async Task<bool> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
