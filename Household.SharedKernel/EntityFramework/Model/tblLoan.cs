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
    
    public partial class tblLoan
    {
        public int LoanID { get; set; }
        public string LoanedTo { get; set; }
        public Nullable<System.DateTime> LoanDate { get; set; }
        public Nullable<decimal> LoanAmount { get; set; }
        public string Purpose { get; set; }
        public Nullable<decimal> AmountPaid { get; set; }
        public Nullable<System.DateTime> PaidDate { get; set; }
        public Nullable<bool> Paid { get; set; }
        public Nullable<decimal> Account { get; set; }
    }
}
