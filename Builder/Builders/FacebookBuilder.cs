using Builder.Enums;
using Builder.Interface;
using Builder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builders
{
    class FacebookBuilder : IReviewBuilder
    {
        private FacebookReviewModel review;

        public void reset()
        {
            review = new FacebookReviewModel();
        }
        public void setRating(Rating rating)
        {
            throw new NotImplementedException();
        }
        public void setAuthorName(string name)
        {
            review.AuthorName = name;
        }
        public void setContent(string content)
        {
            review.Content = content;
        }

        public void setRecommendation(Recommendation recommendation)
        {
            review.Recommendation = recommendation;
        }

        public FacebookReviewModel getReview()
        {
            return review;
        }
    }
}
