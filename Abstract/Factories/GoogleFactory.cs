using Abstract.Interfaces;
using Abstract.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Factories
{
    class GoogleFactory: IDashboardFactory
    {
        public ReviewModel CreateReview()
        {
            return new GoogleReviewModel();
        }
        public ResponseModel CreateResponse()
        {
            return new GoogleResponseModel();
        }
    }
}
