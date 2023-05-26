﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household.Domain.Model.Entities
{
    public abstract class Category : Entity
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
