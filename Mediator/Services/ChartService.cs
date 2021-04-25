using Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Services
{
    class ChartService
    {
        IEmailMediator _mediator;
        public bool chartGenerated;
        public ChartService(IEmailMediator mediator)
        {
            _mediator = mediator;
        }

        public void Generate()
        {
            chartGenerated = true;
            _mediator.Build(this, "ChartGenerated");
        }
    }
}
