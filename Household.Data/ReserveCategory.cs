namespace Household.Data.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReserveCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReserveCategory()
        {
            DeepReserves = new HashSet<DeepReserve>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReserveCategoryID { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        public bool? Display { get; set; }

        public bool? Archived { get; set; }

        public short? ParentCategoryID { get; set; }

        public virtual BudgetCategory BudgetCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeepReserve> DeepReserves { get; set; }
    }
}
