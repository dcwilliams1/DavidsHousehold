using System;
using System.Linq;
using EFModel = Household.Data.EntityFramework.Model;
using DomainModel = Household.Domain.Model.Entities;
using Household.Data.EntityFramework.Repositories;
using Household.Domain.Model.DataInterface;
using System.Collections.Generic;
using Household.Data.EntityFramework.Model;
using AutoMapper;

namespace Household.Data.Services
{
    public class SupplementService : ISupplementData
    {
        private Repository<EFModel.SupplementPurchase> _repo;
        private Mapper _autoMapper = AutoMapper.InitializeAutoMapper();
            
        public SupplementService(Repository<SupplementPurchase> repo)
        { 
            _repo = repo; 
        }
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

            _repo.Add(purchase);
            return true;
        }

        public List<DomainModel.SupplementPurchase> GetSupplementPurchases()
        {
            return _autoMapper.Map<List<EFModel.SupplementPurchase>, List<DomainModel.SupplementPurchase>>(_repo.GetAll().ToList());
        }
    }
}

