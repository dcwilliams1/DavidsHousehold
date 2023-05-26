using System;
using System.Linq;
using Household.Data.EntityFramework;
using EFModel=Household.Data.EntityFramework.Model;
using DomainModel = Household.Domain.Model.Entities;

namespace Household.Data.Repository
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
