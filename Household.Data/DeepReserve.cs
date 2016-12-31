namespace Household.Data.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DeepReserve
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public int? AccountID { get; set; }

        public DateTime? Date { get; set; }

        public int? ReserveCategoryID { get; set; }

        public virtual ReserveAccount ReserveAccount { get; set; }

        public virtual ReserveCategory ReserveCategory { get; set; }
    }
}
