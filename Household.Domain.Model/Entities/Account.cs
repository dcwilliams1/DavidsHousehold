using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household.Domain.Model.Entities
{
    public class Account
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
