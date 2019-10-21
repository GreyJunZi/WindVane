using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using WindVane.Domain.Entities;

namespace WindVane.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        void Add(TEntity entity);
        void Add(IEnumerable<TEntity> entities);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(Guid Id);
        void Remove(TEntity entity);
        void Remove(IEnumerable<TEntity> entities);
        void RemoveRange(IEnumerable<TEntity> entities);

        void Modify(TEntity entity);
        void Modify(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);

        TEntity GetById(object Id);
        IEnumerable<TEntity> GetAll();

        IQueryable<TEntity> Query();

        TEntity Find(object Id);

        int Count();
        long LongCount();

        int SaveChanges();
    }
}
