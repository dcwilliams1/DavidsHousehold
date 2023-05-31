using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Household.SharedKernel.Domain.Model.Entity;
using Household.SharedKernel.EntityFramework;

namespace Household.SharedKernel.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : AggregateRoot
    {
        private IDbContext _dataContext;
        public Repository(IDbContext context)
        {
            _dataContext = context;
        }
        protected IDbSet<TEntity> DbSet
        {
            get
            {
                return _dataContext.Set<TEntity>();
            }
        }

        public TEntity GetById(Guid Id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.AsEnumerable();
        }
        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }
        public virtual void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }
        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_dataContext != null)
                {
                    _dataContext.Dispose();
                    _dataContext = null;
                }
            }
        }
    }
}

//https://www.codeproject.com/Tips/309753/Repository-Pattern-with-Entity-Framework-4-1-and-C