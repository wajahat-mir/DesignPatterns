using Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Services
{
    class HeaderService
    {
        IEmailMediator _mediator;
        public HeaderService(IEmailMediator mediator)
        {
            _mediator = mediator;
        }

        public void Find()
        {
            _mediator.Build(this, "HeaderFileFound");
        }
    }
}
