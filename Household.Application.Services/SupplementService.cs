using System;
using System.Linq;
using Household.Application.Service.Interface;
using Household.Supplements.Domain.Model.Entity;
using Household.SharedKernel.Data.Repository;
using System.Collections.Generic;

namespace Household.Application.Service
{
    public class SupplementService : ISupplementService
    {
        private readonly Repository<SupplementPurchase> _repo;
            
        public SupplementService(IRepository<SupplementPurchase> repo)
        {
            _repo = (Repository<SupplementPurchase>)repo;

        }
        public bool UpdateSupplementPurchase(SupplementPurchase Purchase)
        {
            return true;
        }

        public bool AddSupplementPurchase(SupplementPurchase Purchase)
        {
            _repo.Add(Purchase);
            return true;
        }

        public List<SupplementPurchase> GetSupplementPurchases()
        {

            return _repo.GetAll().ToList();
        }
    }
}

