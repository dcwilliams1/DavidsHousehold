using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household.Domain.Entities
{
    public abstract class Category
    {
        public string Name
        {
            get;
            private set;
        }

        protected virtual void EditCategoryName(string newName)
        {
            this.Name = newName;
        }
    }
}
