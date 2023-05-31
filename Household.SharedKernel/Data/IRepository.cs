using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Household.SharedKernel.Domain.Model.Entity;

namespace Household.SharedKernel.Data.Repository
{
    public interface IRepository<TEntity>
    {
        TEntity GetById(Guid Id);
        IEnumerable<TEntity> GetAll();
        void Delete(TEntity entity);
        void Add(TEntity entity);
        void Update(TEntity entity);
    }
}
