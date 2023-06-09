using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Household.SharedKernel.Domain.Model.Entity;

namespace Household.Supplements.Domain.Model.Entity
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public Int16 ItemCount { get; set; }
        public List<Supplement> Supplements { get; set; }
        public Company Company { get; private set; }
    }
}
