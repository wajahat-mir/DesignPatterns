using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Interfaces
{
    interface IReviewVisitor
    {
        public void visitFacebook();
        public void visitGoogle();
    }
}
