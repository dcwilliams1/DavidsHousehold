using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Household.SharedKernel.Domain.Model.Entity;

namespace Household.Investments.Domain.Model.Entity
{
    public class Account: EntityBase
    {
        public int AccountId { get; private set; }
        public string AccountName { get; private set; }
        public decimal Balance { get; private set; }

        public Account(int accountId)
        {
            this.AccountId = accountId;
        }

    }
}
