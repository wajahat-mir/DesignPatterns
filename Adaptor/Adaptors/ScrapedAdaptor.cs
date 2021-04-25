using Adaptor.Consumers;
using Adaptor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptor.Adaptors
{
    class ScrapedAdaptor: ReviewConsumer
    {
        public ReviewModel Get(ScrapedModel data)
        {
            // mapping would be placed here
            return new ReviewModel();
        }
    }
}
