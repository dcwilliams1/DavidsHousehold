using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Household.SharedKernel.Domain.Model.ValueObject;

namespace Household.Investments.Domain.Model.ValueObject
{
    public abstract class Transaction : ValueObjectBase
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
