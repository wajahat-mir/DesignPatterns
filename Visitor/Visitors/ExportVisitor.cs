using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Interfaces;

namespace Visitor.Visitors
{
    class ExportVisitor:IReviewVisitor
    {
        public void visitFacebook()
        {
            throw new NotImplementedException();
        }
        public void visitGoogle()
        {
            throw new NotImplementedException();
        }
    }
}
