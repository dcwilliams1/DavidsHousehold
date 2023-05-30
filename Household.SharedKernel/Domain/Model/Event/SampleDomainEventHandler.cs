using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household.SharedKernel.Domain.Model.Event
{
    public class SampleDomainEventHandler : IDomainEventHandler<SampleDomainEvent>
    {
        public void Handle(SampleDomainEvent domainEvent)
        {
            //TODO: Handle event here
        }
    }
}
