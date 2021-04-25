using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Interfaces
{
    interface IEmailMediator
    {
        public void Build(object sender, string action);
    }
}
