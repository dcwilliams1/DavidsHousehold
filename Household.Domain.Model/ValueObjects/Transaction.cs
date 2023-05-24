using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household.Domain.Model.ValueObjects
{
    public abstract class Transaction : ValueObject
    {
        public decimal Amount
        {
            get;
            private set;
        }

        protected Transaction(decimal amount)
        {
            this.Amount = amount;
        }

        protected virtual void SetAmount(decimal amount)
        {
            this.Amount = amount;
        }
    }
}
