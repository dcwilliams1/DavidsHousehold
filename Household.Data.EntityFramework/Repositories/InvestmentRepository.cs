using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Household.Data.EntityFramework.Model;
using Household.Domain.Model.DataInterface;
using Household.Domain.Model.Entities;



namespace Household.Data.EntityFramework.Repositories
{
    public class InvestmentRepository: IInvestmentRepository
    {
        public decimal UpdateInvestmentPrinciple(Investment investment, decimal amount)
        {
            using (var db = new Finance())
            {
                
            }
            return investment.Balance;
        }
    }
}
