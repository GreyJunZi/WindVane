using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using WindVane.Data.Context;
using WindVane.Domain.Interfaces;

namespace WindVane.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        protected WindVaneContext _dbContext { get; }
        protected DbSet<TEntity> _dbSet { get; }

        public Repository(WindVaneContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException();

            _dbSet.Add(entity);
        }
        public void Add(IEnumerable<TEntity> entities)
        {
            if (entities == null)
                throw new ArgumentNullException();

            foreach (var entity in entities)
            {
                _dbContext.Entry(entity).State = EntityState.Added;
            }
        }
        public void AddRange(IEnumerable<TEntity> entities)
        {
            if (entities == null)
                throw new ArgumentNullException();

            _dbSet.AddRange(entities);
        }

        public void Remove(Guid Id)
        {
            if (Id == Guid.Empty)
                throw new ArgumentNullException();

            _dbSet.Remove(Find(Id));
        }
        public void Remove(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException();

            _dbSet.Remove(entity);
        }
        public void Remove(IEnumerable<TEntity> entities)
        {
            if (entities == null)
                throw new ArgumentNullException();

            foreach (var entity in entities)
            {
                _dbContext.Entry(entity).State = EntityState.Deleted;
            }
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            if (entities == null)
                throw new ArgumentNullException();

            _dbSet.RemoveRange(entities);
        }

        public void Modify(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException();

            _dbSet.Update(entity);
        }
        public void Modify(IEnumerable<TEntity> entities)
        {
            if (entities == null)
                throw new ArgumentNullException();

            foreach (var entity in entities)
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
            }
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException();

            _dbSet.Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            if (entities == null)
                throw new ArgumentNullException();

            _dbSet.UpdateRange(entities);
        }

        public TEntity GetById(object Id)
        {
            if (Id == null)
                throw new ArgumentNullException();

            return _dbSet.Find(Id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet;
        }


        public IQueryable<TEntity> Query()
        {
            return _dbSet;
        }

        public TEntity Find(object Id)
        {
            return _dbSet.Find(Id);
        }


        public int Count()
        {
            return _dbSet.CountAsync().Result;
        }
        public long LongCount()
        {
            return _dbSet.LongCountAsync().Result;
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }


        public void Dispose()
        {
            _dbContext?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
