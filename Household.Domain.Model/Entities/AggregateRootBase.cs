using System;
using System.Collections.Generic;
using Household.Domain.Model.Events;

namespace Household.Domain.Model.Entities
{
    public abstract class AggregateRoot : Entity
    {
        private List<IDomainEvent> _domainEvents = new ();
        public virtual IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents;

        protected virtual void AddDomainEvent(IDomainEvent newEvent)
        {
            _domainEvents.Add(newEvent);
        }

        public virtual void ClearEvents()
        {
            _domainEvents.Clear(); 
        }
    }
}
