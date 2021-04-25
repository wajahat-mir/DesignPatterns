using Adaptor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptor.Consumers
{
    class ReviewConsumer
    {
        public ReviewModel Get()
        {
            return new ReviewModel();
        }
    }
}
