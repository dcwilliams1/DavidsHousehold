namespace Household.Data.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Finance : DbContext
    {
        public Finance()
            : base("name=Finance")
        {
        }

        public virtual DbSet<BudgetCategory> BudgetCategories { get; set; }
        public virtual DbSet<BudgetLineItem> BudgetLineItems { get; set; }
        public virtual DbSet<DeepReserve> DeepReserves { get; set; }
        public virtual DbSet<EnergyBill> EnergyBills { get; set; }
        public virtual DbSet<MonthlyData> MonthlyDatas { get; set; }
        public virtual DbSet<ReserveAccount> ReserveAccounts { get; set; }
        public virtual DbSet<ReserveCategory> ReserveCategories { get; set; }
        public virtual DbSet<ScheduledTran> ScheduledTrans { get; set; }
        public virtual DbSet<tblDataPoint> tblDataPoints { get; set; }
        public virtual DbSet<TransactionType> TransactionTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<tblAccountFund> tblAccountFunds { get; set; }
        public virtual DbSet<tblAccount> tblAccounts { get; set; }
        public virtual DbSet<tblFund> tblFunds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BudgetCategory>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<BudgetCategory>()
                .Property(e => e.BudgetAmount)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BudgetCategory>()
                .HasMany(e => e.BudgetLineItems)
                .WithRequired(e => e.BudgetCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetCategory>()
                .HasOptional(e => e.BudgetCategories1)
                .WithRequired(e => e.BudgetCategory1);

            modelBuilder.Entity<BudgetCategory>()
                .HasMany(e => e.ReserveCategories)
                .WithOptional(e => e.BudgetCategory)
                .HasForeignKey(e => e.ParentCategoryID);

            modelBuilder.Entity<BudgetCategory>()
                .HasMany(e => e.Users)
                .WithMany(e => e.BudgetCategories)
                .Map(m => m.ToTable("CategoryUser").MapLeftKey("CategoryID").MapRightKey("UserID"));

            modelBuilder.Entity<BudgetLineItem>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BudgetLineItem>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<DeepReserve>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<DeepReserve>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EnergyBill>()
                .Property(e => e.ElectricCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EnergyBill>()
                .Property(e => e.KwHPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EnergyBill>()
                .Property(e => e.SolarSavings)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EnergyBill>()
                .Property(e => e.Therms)
                .HasPrecision(6, 2);

            modelBuilder.Entity<EnergyBill>()
                .Property(e => e.GasCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EnergyBill>()
                .Property(e => e.Mode)
                .IsUnicode(false);

            modelBuilder.Entity<EnergyBill>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<MonthlyData>()
                .Property(e => e.Savings)
                .HasPrecision(10, 4);

            modelBuilder.Entity<ReserveAccount>()
                .Property(e => e.AccountName)
                .IsUnicode(false);

            modelBuilder.Entity<ReserveAccount>()
                .HasMany(e => e.DeepReserves)
                .WithOptional(e => e.ReserveAccount)
                .HasForeignKey(e => e.AccountID);

            modelBuilder.Entity<ReserveCategory>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTran>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTran>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblDataPoint>()
                .Property(e => e.DataValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblDataPoint>()
                .Property(e => e.Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransactionType>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionType>()
                .HasMany(e => e.BudgetLineItems)
                .WithRequired(e => e.TransactionType)
                .HasForeignKey(e => e.TransTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Lname)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Fname)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.BudgetLineItems)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblAccount>()
                .Property(e => e.AccountName)
                .IsUnicode(false);

            modelBuilder.Entity<tblAccount>()
                .Property(e => e.AccountDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tblAccount>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tblAccount>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<tblFund>()
                .Property(e => e.FundSymbol)
                .IsUnicode(false);

            modelBuilder.Entity<tblFund>()
                .Property(e => e.FundName)
                .IsUnicode(false);
        }
    }
}
