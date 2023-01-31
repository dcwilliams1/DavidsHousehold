using Household.Domain.Model.Entities;

namespace Household.Domain.Model.DataInterface
{
    public interface IInvestmentData
    {
        bool UpdateInvestmentPrinciple(Investment Investment, decimal Amount);
    }
}
