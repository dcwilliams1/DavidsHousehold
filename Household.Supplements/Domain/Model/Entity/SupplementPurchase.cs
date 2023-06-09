using System;
using System.Collections.Generic;
using Household.SharedKernel.Domain.Model.Event;
using Household.SharedKernel.Domain.Model.Entity;
namespace Household.Supplements.Domain.Model.Entity
{
    public class SupplementPurchase : AggregateRoot
    {
        public DateTime Date { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public Int16 Quantity { get; set; }
        public void SampleMethodWithEvent()
        {
            AddDomainEvent(new SampleDomainEvent());
        }
    }
}
