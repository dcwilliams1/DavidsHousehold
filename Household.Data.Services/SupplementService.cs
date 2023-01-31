using System;
using System.Linq;
using EFModel = Household.Data.EntityFramework.Model;
using DomainModel = Household.Domain.Model.Entities;
using Household.Data.EntityFramework.Repositories;


namespace Household.Data.Services
{
    public class SupplementService
    {
        public bool UpdateSupplementPurchase(DomainModel.SupplementPurchase Purchase)
        {
            return true;
        }

        public bool AddSupplementPurchase(DomainModel.SupplementPurchase Purchase)
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

            var context = new FinanceDbContext();
            var repo = new Repository<EFModel.SupplementPurchase>(context);
            repo.Add(purchase);
            return true;
        }

    }
}

