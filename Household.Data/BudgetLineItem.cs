namespace Household.Data.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BudgetLineItem
    {
        [Key]
        public int LineID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Date { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(75)]
        public string Description { get; set; }

        public short CategoryID { get; set; }

        public byte TransTypeID { get; set; }

        public bool Status { get; set; }

        public byte UserID { get; set; }

        public virtual BudgetCategory BudgetCategory { get; set; }

        public virtual TransactionType TransactionType { get; set; }

        public virtual User User { get; set; }
    }
}
