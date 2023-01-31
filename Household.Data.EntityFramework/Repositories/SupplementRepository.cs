using System;
using System.Linq;
using Household.Data.EntityFramework.Model;

namespace Household.Data.EntityFramework.Repositories
{
    public class SupplementRepository : Repository<SupplementPurchase>
    {
        
        public SupplementRepository(FinanceDbContext context)
        {

        }
        public IQueryable<SupplementPurchase> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Delete(SupplementPurchase supplementPurchase)
        {
            throw new NotImplementedException();
        }
        public void Add(SupplementPurchase supplementPurchase)
        {
            throw new NotImplementedException();
        }

        public void Update(SupplementPurchase supplementPurchase)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            base.Dispose();
        }

    }
}
