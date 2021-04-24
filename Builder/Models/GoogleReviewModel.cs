using Builder.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Models
{
    class GoogleReviewModel
    {
        public Rating Rating { get; set; }
        public string AuthorName { get; set; }
        public string Content { get; set; }
    }
}
