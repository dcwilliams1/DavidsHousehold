namespace Household.Data.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblDataPoint
    {
        [Key]
        public int DataPointID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DataDate { get; set; }

        [Column(TypeName = "money")]
        public decimal DataValue { get; set; }

        public short AccountFundID { get; set; }

        [StringLength(1)]
        public string Type { get; set; }
    }
}
