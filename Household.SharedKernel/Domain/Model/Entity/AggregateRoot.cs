using System;
using System.Collections.Generic;
using Household.SharedKernel.Domain.Model.Event;

namespace Household.SharedKernel.Domain.Model.Entity
{
    public abstract class AggregateRoot : EntityBase
    {
        private List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
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
