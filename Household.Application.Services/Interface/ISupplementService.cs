using System;
using System.Collections.Generic;
using Household.Supplements.Domain.Model.Entity;

namespace Household.Application.Service.Interface
{
    public interface ISupplementService
    {
        bool UpdateSupplementPurchase(SupplementPurchase Purchase);
        bool AddSupplementPurchase(SupplementPurchase Purchase);
        List<SupplementPurchase> GetSupplementPurchases();
    }
}
