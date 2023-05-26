using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household.Domain.Model.Entities
{
    public class BudgetCategory : Category
    {
        protected override void EditCategoryName(string newname)
        {
            base.EditCategoryName(newname);
        }

        //public BudgetCategory()
        //{

        //}

        public BudgetCategory(string name)
        {
            base.EditCategoryName(name);
        }

        public decimal BudgetAmount
        {
            get;
            protected set;
        }
    }
}
