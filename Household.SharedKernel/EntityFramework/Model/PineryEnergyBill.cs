//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Household.SharedKernel.EntityFramework.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PineryEnergyBill
    {
        public int Id { get; set; }
        public System.DateTime MonthEnd { get; set; }
        public int DaysInPeriod { get; set; }
        public int KwH { get; set; }
        public decimal ElectricCost { get; set; }
        public int Meter { get; set; }
        public int Therms { get; set; }
        public decimal GasCost { get; set; }
        public Nullable<int> AvgTemp { get; set; }
        public string Mode { get; set; }
        public string Comment { get; set; }
    }
}
