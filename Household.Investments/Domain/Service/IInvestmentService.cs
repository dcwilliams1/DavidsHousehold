using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Household.Investments.Domain.Model.Entity;

namespace Household.Investments.Domain.Service
{
    public interface IInvestmentService
    {
        decimal UpdateInvestmentPrinciple(Investment investment, decimal amount);
    }
}
