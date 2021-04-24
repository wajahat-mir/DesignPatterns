using Abstract.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Interfaces
{
    interface IDashboardFactory
    {
        public ReviewModel CreateReview();
        public ResponseModel CreateResponse();
    }
}
