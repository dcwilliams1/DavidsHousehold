using Household.Supplements.Domain.Model.Entity;
using System.Collections.Generic;

namespace Household.Domain.Model.DataInterface
{
    public interface ISupplementRepository
    {
        bool UpdateSupplementPurchase(SupplementPurchase Purchase);
        bool AddSupplementPurchase(SupplementPurchase Purchase);
        List<SupplementPurchase> GetSupplementPurchases();
    }
}
