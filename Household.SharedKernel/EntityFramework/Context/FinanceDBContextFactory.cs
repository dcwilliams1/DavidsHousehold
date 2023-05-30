
using System.Data.Entity.Infrastructure;

namespace Household.SharedKernel.EntityFramework
{
    public class FinanceDBContextFactory : IDbContextFactory<FinanceDbContext>
    {
        public FinanceDbContext Create()
        {
            return new FinanceDbContext("Server=(localdb)\\mssqllocaldb;Database=Finance;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
