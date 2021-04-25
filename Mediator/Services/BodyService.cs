using Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Services
{
    class BodyService
    {
        IEmailMediator _mediator;
        public BodyService(IEmailMediator mediator)
        {
            _mediator = mediator;
        }

        public void Create()
        {
            _mediator.Build(this, "BodyCreated");
        }
    }
}
