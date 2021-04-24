using Builder.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Models
{
    class FacebookReviewModel
    {
        public Recommendation Recommendation { get; set; }
        public string AuthorName { get; set; }
        public string Content { get; set; }
    }
}
