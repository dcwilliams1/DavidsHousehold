using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household.Domain.Entities
{
    public class Fund
    {
         public int FundId { get; private set; }
         public string FundName { get; private set; }

         public Fund(int fundId)
        {
            this.FundId = fundId;
        }

    }
}
