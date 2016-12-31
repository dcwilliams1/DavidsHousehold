namespace Household.Data.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblAccountFund
    {
        [Key]
        [Column(Order = 0)]
        public short AccountFundID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte FundID { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte AccountID { get; set; }
    }
}
