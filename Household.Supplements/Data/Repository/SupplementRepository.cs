using System;
using System.Linq;
using Household.SharedKernel.EntityFramework;
using EFModel=Household.SharedKernel.EntityFramework.Model;
using DomainModel = Household.Supplements.Domain.Model.Entity;
using Household.SharedKernel.Data.Repository;
using System.Collections.Generic;
using AutoMapper;

namespace Household.Supplements.Data.Repository
{
    public class SupplementRepository : Repository<DomainModel.SupplementPurchase>
    {
        private Mapper _mapper;
        public SupplementRepository(FinanceDbContext context) : base(context)
        {
            _mapper = MapperConfig.InitializeAutoMapper();
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

        public override IEnumerable<DomainModel.SupplementPurchase> GetAll()
        {
            var supplementPurchases = ((FinanceDbContext)db).SupplementPurchase.Include("Product");
            List<DomainModel.SupplementPurchase> returnValue = _mapper.Map<List<DomainModel.SupplementPurchase>>(supplementPurchases);
            return returnValue;
        }
    }
}

//https://rogerjohansson.blog/2013/12/01/why-mapping-dtos-to-entities-using-automapper-and-entityframework-is-horrible/
//https://docs.automapper.org/en/stable/Lists-and-arrays.html
//https://dotnettutorials.net/lesson/automapper-in-c-sharp/