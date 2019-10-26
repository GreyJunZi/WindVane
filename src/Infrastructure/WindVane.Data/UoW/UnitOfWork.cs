using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WindVane.Domain.Interfaces;

namespace WindVane.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void BeginTransaction()
        {
            _dbContext.Database.BeginTransaction();
        }

        public async Task BeginTransactionAsync()
        {
            await _dbContext.Database.BeginTransactionAsync();
        }

        public bool Commit()
        {
            return _dbContext.SaveChanges() > 0;
        }

        public async Task<bool> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public void CommitTransaction()
        {
            _dbContext.Database.CommitTransaction();
        }

        public void RollbackTransaction()
        {
            _dbContext.Database.RollbackTransaction();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
