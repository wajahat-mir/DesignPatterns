using Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Services
{
    class EmailMediator: IEmailMediator
    {
        private BodyService Body;
        private ChartService Chart;
        private HeaderService Header;

        public void Build(object sender, string action)
        {
            
        }
    }
}
