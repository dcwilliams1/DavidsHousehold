namespace Household.Data.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            BudgetLineItems = new HashSet<BudgetLineItem>();
            BudgetCategories = new HashSet<BudgetCategory>();
        }

        public byte UserID { get; set; }

        [StringLength(50)]
        public string Lname { get; set; }

        [Required]
        [StringLength(50)]
        public string Fname { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(30)]
        public string Username { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BudgetLineItem> BudgetLineItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BudgetCategory> BudgetCategories { get; set; }
    }
}
