using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household.Domain.Entities
{
    public class BudgetCategory : Category
    {
        protected override void EditCategoryName(string newName)
        {
            base.EditCategoryName(newName);
        }

        public BudgetCategory()
        {

        }

        public BudgetCategory(string name)
        {
            this.EditCategoryName(name);
        }

        public decimal BudgetAmount
        {
            get;
            protected set;
        }
    }
}
