using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Household.Domain.Model.Entities;

namespace Household.Domain.Model.ServiceInterface
{
    public interface IInvestmentService
    {
        decimal UpdateInvestmentPrinciple(Investment investment, decimal amount);
    }
}
