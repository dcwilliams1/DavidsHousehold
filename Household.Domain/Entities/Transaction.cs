﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household.Domain.Entities
{
    public class Transaction
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

        public decimal Amount
        {
            get
            {
                return this.amount;
            }
        }

        private Investment investment;
        private decimal amount;

        public Transaction(Investment Investment, decimal Amount)
        {
            this.investment = Investment;
            this.amount = Amount;
            this.investment.UpdateBalance(amount);
        }

    }
}
