using Builder.Enums;
using Builder.Interface;
using Builder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builders
{
    class GoogleBuilder: IReviewBuilder
    {
        private GoogleReviewModel review;

        public void reset()
        {
            review = new GoogleReviewModel();
        }
        public void setRating(Rating rating)
        {
            review.Rating = rating;
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
            throw new NotImplementedException();
        }

        public GoogleReviewModel getReview()
        {
            return review;
        }

    }
}
