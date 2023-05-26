using System.Data.Entity;
using Household.Data.EntityFramework.Model;


namespace Household.Data.EntityFramework
{
    public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
        void Dispose();
    }

    public class FinanceDbContext : FinanceDB, IDbContext
    {
        public FinanceDbContext(string connectionString) : base(connectionString)
        {

        }
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

//https://learn.microsoft.com/en-us/aspnet/core/data/entity-framework-6?view=aspnetcore-2.1
