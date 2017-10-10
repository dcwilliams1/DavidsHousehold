using Household.Domain.Model.Entities;

namespace Household.Domain.Model.DataInterface
{
    public interface IInvestmentRepository
    {
        bool UpdateInvestmentPrinciple(Investment Investment, decimal Amount);
    }
}
