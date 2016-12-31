namespace Household.Data.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EnergyBill
    {
        [Key]
        public int BillID { get; set; }

        public DateTime? BillEnd { get; set; }

        public int? DaysInPeriod { get; set; }

        public int? KwH { get; set; }

        [Column(TypeName = "money")]
        public decimal? ElectricCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? KwHPrice { get; set; }

        public int? Meter { get; set; }

        public int? SolarProduction { get; set; }

        public int? SolarUsage { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? SolarSavings { get; set; }

        public decimal? Therms { get; set; }

        [Column(TypeName = "money")]
        public decimal? GasCost { get; set; }

        public int? AvgTemp { get; set; }

        public int? Thermostat { get; set; }

        [StringLength(4)]
        public string Mode { get; set; }

        [StringLength(300)]
        public string Comment { get; set; }
    }
}
