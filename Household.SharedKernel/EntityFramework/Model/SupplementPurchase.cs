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
    
    public partial class SupplementPurchase
    {
        public System.Guid Id { get; set; }
        public int ProductId { get; set; }
        public System.DateTime PurchaseDate { get; set; }
        public short Quantity { get; set; }
        public decimal Price { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
