using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Household.SharedKernel.EntityFramework.Model;
using Household.Investments.Domain.Model.Entity;



namespace Household.Investments.Data.Repository
{
    public class InvestmentRepository
    {
        public bool UpdateInvestmentPrinciple(Investment Investment, decimal Amount)
        {
            using (var db = new FinanceDB())
            {
                return true;
            }
        }
    }
}
