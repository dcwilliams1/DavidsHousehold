using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;

namespace Household.Data.EntityFramework.Repositories
{
    public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
        void Dispose();
    }

    public interface IRepository<TEntity> 
    {
        IQueryable<TEntity> GetAll();
        void Delete(TEntity entity);
        void Add(TEntity entity);

        void Update(TEntity entity);
    }

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private IDbContext _context;
        public Repository(IDbContext context)
        {
            _context = context;
        }
        private IDbSet<TEntity> DbSet
        {
            get
            {
                return _context.Set<TEntity>();
            }
        }
        public IQueryable<TEntity> GetAll()
        {
            return DbSet.AsQueryable();
        }
        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }
        public void Add(TEntity entity)
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
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}

//https://www.codeproject.com/Tips/309753/Repository-Pattern-with-Entity-Framework-4-1-and-C