using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Household.Domain.Model.DataInterface;
using Household.Domain.Model.Entities;
using Household.Domain.Model.ServiceInterface;
using Household.Domain.Model.ValueObjects;

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
