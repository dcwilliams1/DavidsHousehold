using System;
using System.Linq;
using Household.SharedKernel.EntityFramework;
using EFModel=Household.SharedKernel.EntityFramework.Model;
using DomainModel = Household.Supplements.Domain.Model.Entity;
using Household.SharedKernel.Data.Repository;

namespace Household.Supplements.Data.Repository
{
    public class SupplementRepository : Repository<DomainModel.SupplementPurchase>
    { 
        
        public SupplementRepository(FinanceDbContext context) : base(context)
        {

        }
        
        public override void Add(DomainModel.SupplementPurchase Purchase)
        {
            EFModel.SupplementPurchase purchase = new EFModel.SupplementPurchase()
            {
                Id = Purchase.Id,
                PurchaseDate = Purchase.Date,
                Quantity = Purchase.Quantity,
                Price = Purchase.Price,
                Product = new EFModel.Product()
                {
                    Name = Purchase.Product,
                    Company = new EFModel.Company()
                    {
                        Name = Purchase.Company,
                    },
                    Count = Purchase.Count,
                },
            };
            purchase.Product.ProductSupplements.Add(new EFModel.ProductSupplement()
            {
                StrengthMg = (Int16)Purchase.Strength,
                Dose = (byte)Purchase.Dose,
                Supplement = new EFModel.Supplement()
                {
                    Name = Purchase.Supplement,
                }
            });
        }
    }
}
