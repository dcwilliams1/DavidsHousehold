using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Household.SharedKernel.Domain.Model.Entity;

namespace Household.Investments.Domain.Model.Entity
{
    public class Fund : EntityBase
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
