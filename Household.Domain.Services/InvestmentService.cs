using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Household.Domain.Model.DataInterface;
using Household.Domain.Model.Entities;
using Household.Domain.Model.ServiceInterface;

namespace Household.Domain.Services
{
    public class InvestmentService:IInvestmentService
    {
        private readonly IInvestmentRepository _investmentRepository;

        public InvestmentService(IInvestmentRepository investmentRepository)
        {
            _investmentRepository = investmentRepository;
        }

        public decimal UpdateInvestmentPrinciple(Investment investment, decimal amount)
        {
            decimal newBalance = _investmentRepository.UpdateInvestmentPrinciple(investment, amount);

            return newBalance;
        }
    }
}
