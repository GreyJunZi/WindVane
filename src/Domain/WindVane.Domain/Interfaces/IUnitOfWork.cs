using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WindVane.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();

        Task BeginTransactionAsync();

        bool Commit();

        Task<bool> CommitAsync();

        void CommitTransaction();

        void RollbackTransaction();
    }
}
