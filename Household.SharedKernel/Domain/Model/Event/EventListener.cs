using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Household.SharedKernel.Domain.Model.Entity;

namespace Household.SharedKernel.Domain.Model.Event
{
    public class EventListener
    {
        public void DispatchEvents(AggregateRoot aggregate)
        {
            foreach (DomainEvent domainEvent in aggregate.DomainEvents)
            {
                DomainEvents.Dispatch(domainEvent);
            }
        }
    }
}
