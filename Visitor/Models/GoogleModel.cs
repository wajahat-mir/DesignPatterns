using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Interfaces;

namespace Visitor.Models
{
    class GoogleModel:IReview
    {
        public void accept(IReviewVisitor reviewVisitor)
        {
            reviewVisitor.visitGoogle();
        }
    }
}
