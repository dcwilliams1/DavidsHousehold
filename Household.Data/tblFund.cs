namespace Household.Data.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblFund
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte FundID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string FundSymbol { get; set; }

        [StringLength(50)]
        public string FundName { get; set; }
    }
}
