namespace Household.Data.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ScheduledTran
    {
        [Key]
        public int TranID { get; set; }

        public byte TranTypeID { get; set; }

        public short CategoryID { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public byte? Day { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public byte? UserID { get; set; }

        public bool Active { get; set; }

        public DateTime? LastEntry { get; set; }
    }
}
