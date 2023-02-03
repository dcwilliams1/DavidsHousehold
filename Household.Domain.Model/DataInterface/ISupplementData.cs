using Household.Domain.Model.Entities;
using System.Collections.Generic;

namespace Household.Domain.Model.DataInterface
{
    public interface ISupplementData
    {
        bool UpdateSupplementPurchase(SupplementPurchase Purchase);
        bool AddSupplementPurchase(SupplementPurchase Purchase);
        List<SupplementPurchase> GetSupplementPurchases();
    }
}
