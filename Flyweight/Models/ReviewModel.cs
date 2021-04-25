using Flyweight.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class ReviewModel
    {
        public LocationModel location { get; set; }

        public ReviewModel(LocationModel location)
        {
            this.location = location;
        }

    }
}
