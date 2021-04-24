using Builder.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Interface
{
    interface IReviewBuilder
    {
        public void reset();
        public void setRating(Rating rating);
        public void setRecommendation(Recommendation recommendation);
        public void setAuthorName(string name);
        public void setContent(string content);
    }
}
