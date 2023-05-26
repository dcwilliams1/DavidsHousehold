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
    public class InvestmentRepository: IInvestmentData
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
