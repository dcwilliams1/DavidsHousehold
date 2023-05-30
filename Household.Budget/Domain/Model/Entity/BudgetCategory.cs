using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household.Budget.Domain.Model.Entity
{
    public class BudgetCategory : Category
    {
        public override void EditCategoryName(string newname)
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
