using System;
using System.Data.Entity;
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
        private FinanceDbContext _financeDb;
        public SupplementRepository(FinanceDbContext context) : base(context)
        {
            _mapper = MapperConfig.InitializeAutoMapper();
            _financeDb = context;
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
                    Name = Purchase.Product.Name,
                    Company = new EFModel.Company()
                    {
                        Name = Purchase.Product.Company.Name,
                    },
                    Count = Purchase.Product.ItemCount,
                },
            };
            var existingProductSupplements = _financeDb.ProductSupplements.Where(ps => ps.ProductId == purchase.ProductId);

            foreach (DomainModel.Supplement supplement in Purchase.Product.Supplements)
            {
                if (!existingProductSupplements.Any(ps => ps.Supplement.Id == supplement.Id))
                {
                    purchase.Product.ProductSupplements.Add(new EFModel.ProductSupplement()
                    {
                        Supplement = new EFModel.Supplement()
                        {
                            Name = supplement.Name
                        }
                    });
                }
            }
        }

        public override IEnumerable<DomainModel.SupplementPurchase> GetAll()
        {
            var supplementPurchases = _financeDb.SupplementPurchases.Include(sp => sp.Product.Company).Include(sp => sp.Product.ProductSupplements);
            List<DomainModel.SupplementPurchase> returnValue = _mapper.Map<List<DomainModel.SupplementPurchase>>(supplementPurchases);
            return returnValue;
        }
    }
}

//https://rogerjohansson.blog/2013/12/01/why-mapping-dtos-to-entities-using-automapper-and-entityframework-is-horrible/
//https://docs.automapper.org/en/stable/Lists-and-arrays.html
//https://dotnettutorials.net/lesson/automapper-in-c-sharp/
//https://www.entityframeworktutorial.net/efcore/create-model-for-existing-database-in-ef-core.aspx
//https://learn.microsoft.com/en-us/ef/ef6/querying/related-data