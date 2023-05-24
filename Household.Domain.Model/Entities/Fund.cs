using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household.Domain.Model.Entities
{
    public class Fund : Entity
    {
         public int FundId { get; private set; }
         public string FundName { get; private set; }

         public decimal Balance { get; private set; }

         public Fund(int fundId)
        {
            this.FundId = fundId;
        }

    }
}
