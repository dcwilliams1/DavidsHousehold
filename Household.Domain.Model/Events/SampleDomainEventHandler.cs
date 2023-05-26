using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household.Domain.Model.Events
{
    public class SampleDomainEventHandler : IDomainEventHandler<SampleDomainEvent>
    {
        public void Handle(SampleDomainEvent domainEvent)
        {
            //TODO: Handle event here
        }
    }
}
