using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Household.SharedKernel.Domain.Model.Entity;

namespace Household.Supplements.Domain.Model.Entity
{
    public class Supplement: EntityBase
    {
        public string Name { get; private set; }
    }
}
