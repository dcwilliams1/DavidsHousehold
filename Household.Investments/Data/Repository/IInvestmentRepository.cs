using Household.Investments.Domain.Model.Entity;

namespace Household.Investments.Data.Repository
{
    public interface IInvestmentRepository
    {
        bool UpdateInvestmentPrinciple(Investment Investment, decimal Amount);
    }
}
