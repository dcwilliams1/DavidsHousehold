using System;

namespace Household.Domain.Model.Events
{
    public abstract class DomainEvent
    {
        public DateTime DateOccurred { get; protected set; }
    }
}
