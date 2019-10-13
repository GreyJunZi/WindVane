using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WindVane.Domain.Interfaces
{
    public interface IUnitOfWork
    {

        bool Commit();

        Task<bool> CommitAsync();
    }
}
