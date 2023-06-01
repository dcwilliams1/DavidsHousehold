using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Household.Investments.Domain.Model.Entity;

namespace Household.Investments.Domain.Model.ValueObject
{
    public class InvestmentTransaction: Transaction
    {
        public Investment Investment
        {
            get
            {
                if (this.investment != null)
                {     
                    return this.investment;
                }
                else
                {
                    throw new Exception("Error: no investment set for this transaction");
                }
            }
        }


        private readonly Investment investment;

        public InvestmentTransaction(Investment investment, decimal amount) : base(amount)
        {
            this.investment = investment;
            this.investment.UdatePrinciple(amount);

        }

        public InvestmentTransaction(decimal amount) : base(amount)
        {
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
