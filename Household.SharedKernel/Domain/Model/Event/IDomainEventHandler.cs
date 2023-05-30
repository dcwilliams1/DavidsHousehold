using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household.SharedKernel.Domain.Model.Event
{
    public interface IDomainEventHandler<T> where T: IDomainEvent
    {
        void Handle(T domainEvent);
    }
}
