using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using Household.Data.EntityFramework.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household.Data.EntityFramework
{
    public class FinanceDBContextFactory : IDbContextFactory<FinanceDbContext>
    {
        public FinanceDbContext Create()
        {
            return new FinanceDbContext("Server=(localdb)\\mssqllocaldb;Database=Finance;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
