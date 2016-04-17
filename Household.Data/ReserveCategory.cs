//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Household.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReserveCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReserveCategory()
        {
            this.DeepReserves = new HashSet<DeepReserve>();
        }
    
        public int ReserveCategoryID { get; set; }
        public string CategoryName { get; set; }
        public Nullable<bool> Display { get; set; }
        public Nullable<bool> Archived { get; set; }
        public Nullable<short> ParentCategoryID { get; set; }
    
        public virtual BudgetCategory BudgetCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeepReserve> DeepReserves { get; set; }
    }
}
