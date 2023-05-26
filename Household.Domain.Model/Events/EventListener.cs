using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Household.Domain.Model.Entities;

namespace Household.Domain.Model.Events
{
    public class EventListener
    {
        public void DispatchEvents(AggregateRoot aggregate)
        {
            foreach (IDomainEvent domainEvent in aggregate.DomainEvents)
            {
                DomainEvents.Dispatch(domainEvent);
            }
        }
    }
}
