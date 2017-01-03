using Household.Domain.Model.Entities;

namespace Household.Domain.Model.DataInterface
{
    public interface IInvestmentRepository
    {
        decimal UpdateInvestmentPrinciple(Investment investment, decimal amount);
    }
}
