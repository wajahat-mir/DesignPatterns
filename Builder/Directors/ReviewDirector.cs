using Builder.Enums;
using Builder.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Directors
{
    class ReviewDirector
    {
        public void constructBadGoogleReview(IReviewBuilder builder)
        {
            builder.reset();
            builder.setRating(Rating.ONE);
            builder.setContent("Horrible place");
            builder.setAuthorName("John Smith");
        }

        public void constructAmazingFacebookRecommendation(IReviewBuilder builder)
        {
            builder.reset();
            builder.setRecommendation(Recommendation.RECOMMMEND);
            builder.setContent("Great place!");
            builder.setAuthorName("Jane Doe");
        }
    }
}
