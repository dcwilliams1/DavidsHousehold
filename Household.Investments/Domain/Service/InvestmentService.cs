using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Household.Investments.Data.Repository;
using Household.Investments.Domain.Model.ValueObject;
using Household.Investments.Domain.Model.Entity;

namespace Household.Investments.Domain.Service
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
            var tran = new InvestmentTransaction(investment, amount);

            try
            {
                bool updateSucceeded = _investmentRepository.UpdateInvestmentPrinciple(investment, amount);

                return investment.Principle;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Database update failed in Investment Repository. {0} {1}", ex.Message, ex.InnerException));
            }
        }
    }
}
