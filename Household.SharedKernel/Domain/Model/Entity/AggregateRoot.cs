using System;
using System.Collections.Generic;
using Household.SharedKernel.Domain.Model.Event;

namespace Household.SharedKernel.Domain.Model.Entity
{
    public abstract class AggregateRoot : EntityBase
    {
        private List<DomainEvent> _domainEvents = new List<DomainEvent>();
        public virtual IReadOnlyList<DomainEvent> DomainEvents => _domainEvents;

        protected virtual void AddDomainEvent(DomainEvent newEvent)
        {
            _domainEvents.Add(newEvent);
        }

        public virtual void ClearEvents()
        {
            _domainEvents.Clear(); 
        }
    }
}
