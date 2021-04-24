using Abstract.Interfaces;
using Abstract.Models;
using Abstract.Models.Facebook;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Factories
{
    class FacebookFactory: IDashboardFactory
    {
        public ReviewModel CreateReview()
        {
            return new FacebookReviewModel();
        }

        public ResponseModel CreateResponse()
        {
            return new FacebookResponseModel();
        }
    }
}
