using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Household.SharedKernel.Domain.Model.Entity;

namespace Household.Budget.Domain.Model.Entity
{
    public abstract class Category : EntityBase
    {
        public string Name
        {
            get;
            private set;
        }

        public virtual void EditCategoryName(string newName)
        {
            this.Name = newName;
        }
    }
}
