using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Household.Data.EntityFramework.Model;
using System.Data;

namespace Household.Data.EntityFramework.Repositories
{
    public class FinanceDbContext : FinanceDB, IDbContext
    {
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }

    public interface IDatabaseInitializer<in TContext> where TContext : IDbContext
    {
        // Summary:
        //   Executes the strategy to initialize
        //   the database for the given context.
        // Parameters:
        //   context: The context.
        void InitializeDatabase(TContext context);
    }

    public class DataBaseInitializer : IDatabaseInitializer<FinanceDbContext>
    {
        public void InitializeDatabase(FinanceDbContext context)
        {
            context.Database.Delete();
            context.Database.Create();
        }
    }
}
