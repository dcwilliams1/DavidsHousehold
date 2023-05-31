using System;

namespace Household.SharedKernel.Domain.Model.Event
{
    public abstract class DomainEvent
    {
        public DateTimeOffset TimeOccurred { get; protected set; } = DateTimeOffset.Now;
    }
}
