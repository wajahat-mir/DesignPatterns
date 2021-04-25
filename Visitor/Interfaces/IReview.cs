using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Interfaces
{
    interface IReview
    {
        public void accept(IReviewVisitor reviewVisitor);
    }
}
