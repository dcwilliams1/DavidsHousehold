//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Household.SharedKernel.EntityFramework.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BudgetCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BudgetCategory()
        {
            this.BudgetLineItems = new HashSet<BudgetLineItem>();
            this.ReserveCategories = new HashSet<ReserveCategory>();
            this.Users = new HashSet<User>();
        }
    
        public short CategoryID { get; set; }
        public string CategoryName { get; set; }
        public Nullable<decimal> BudgetAmount { get; set; }
        public bool Display { get; set; }
        public bool Archived { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BudgetLineItem> BudgetLineItems { get; set; }
        public virtual BudgetCategory BudgetCategories1 { get; set; }
        public virtual BudgetCategory BudgetCategory1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReserveCategory> ReserveCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
