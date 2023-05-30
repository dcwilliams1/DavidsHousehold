using System;
using Household.SharedKernel.Domain.Model.Event;
using Household.SharedKernel.Domain.Model.Entity;
namespace Household.Supplements.Domain.Model.Entity
{
    public class SupplementPurchase : AggregateRoot
    {
        public DateTime Date { get; set; }
        public string Company { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public Int16 Quantity { get; set; }
        public string Supplement { get; set; }
        public int Strength { get; set; }
        public int Dose { get; set; }
        public Int16 Count { get; set; }

        public void SampleMethodWithEvent()
        {
            AddDomainEvent(new SampleDomainEvent());
        }
    }
}
