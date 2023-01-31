using Household.Domain.Model.Entities;

namespace Household.Domain.Model.DataInterface
{
    public interface ISupplementData
    {
        bool UpdateSupplementPurchase(SupplementPurchase Purchase);
        bool AddSupplementPurchase(SupplementPurchase Purchase);
    }
}
