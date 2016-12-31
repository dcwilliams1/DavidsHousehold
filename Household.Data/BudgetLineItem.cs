//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Household.Data.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class BudgetLineItem
    {
        public int LineID { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Amount { get; set; }
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
