using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Interfaces;

namespace Visitor.Models
{
    class FacebookModel:IReview
    {
        public void accept(IReviewVisitor reviewVisitor)
        {
            reviewVisitor.visitFacebook();
        }
    }
}
