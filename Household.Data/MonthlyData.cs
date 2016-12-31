namespace Household.Data.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonthlyData")]
    public partial class MonthlyData
    {
        [Key]
        [Column(Order = 0)]
        public byte MonthID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short YearID { get; set; }

        public bool? Initialized { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? Savings { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte UserID { get; set; }
    }
}
