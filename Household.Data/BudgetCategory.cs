namespace Household.Data.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BudgetCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BudgetCategory()
        {
            BudgetLineItems = new HashSet<BudgetLineItem>();
            ReserveCategories = new HashSet<ReserveCategory>();
            Users = new HashSet<User>();
        }

        [Key]
        public short CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? BudgetAmount { get; set; }

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
