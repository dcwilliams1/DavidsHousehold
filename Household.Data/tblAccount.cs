namespace Household.Data.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblAccount
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte AccountID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string AccountName { get; set; }

        [StringLength(250)]
        public string AccountDescription { get; set; }

        [StringLength(20)]
        public string AccountNumber { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Active { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Display { get; set; }
    }
}
