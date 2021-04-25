using Adaptor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptor.Consumers
{
    class ScrapedConsumer
    {
        public ScrapedModel Get()
        {
            return new ScrapedModel();
        }
    }
}
