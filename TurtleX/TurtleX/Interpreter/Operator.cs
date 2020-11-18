using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurtleX.Interpreter
{
    abstract class Operator : IExpression
    {
        protected IExpression left;
        protected IExpression right;

        public Operator(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public virtual double eval()
        {
            return 0;
        }
    }
}
