namespace Household.Data.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReserveAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReserveAccount()
        {
            DeepReserves = new HashSet<DeepReserve>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReserveAccountID { get; set; }

        [StringLength(50)]
        public string AccountName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeepReserve> DeepReserves { get; set; }
    }
}
