using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Household.Domain.Model.Entities;

namespace Household.Domain.Model.ValueObjects
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


        private Investment investment;

        public InvestmentTransaction(Investment investment, decimal amount) : base(amount)
        {
            this.investment = investment;

        }

    }
}
