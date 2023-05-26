using System;
using System.Linq;
using EFModel = Household.Data.EntityFramework.Model;
using DomainModel = Household.Domain.Model.Entities;
using Household.Data.Repository;
using Household.Domain.Model.DataInterface;
using System.Collections.Generic;
using Household.Data.EntityFramework.Model;
using AutoMapper;

namespace Household.Data.Services
{
    public class SupplementService : ISupplementData
    {
        private Repository<DomainModel.SupplementPurchase> _repo;
        private Mapper _autoMapper = AutoMapper.InitializeAutoMapper();
            
        public SupplementService(Repository<DomainModel.SupplementPurchase> repo)
        {
            _repo = (Repository<DomainModel.SupplementPurchase>)repo;
        }
        public bool UpdateSupplementPurchase(DomainModel.SupplementPurchase Purchase)
        {
            return true;
        }

        public bool AddSupplementPurchase(DomainModel.SupplementPurchase Purchase)
        {
            _repo.Add(Purchase);
            return true;
        }

        public List<DomainModel.SupplementPurchase> GetSupplementPurchases()
        {
            return _autoMapper.Map<List<SupplementPurchase>, List<DomainModel.SupplementPurchase>>(_repo.GetAll().ToList());
        }
    }
}

