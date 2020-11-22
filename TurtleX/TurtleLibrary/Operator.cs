using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurtleLibrary
{
    public abstract class Operator : IExpression
    {
        protected IExpression left;
        protected IExpression right;

        public Operator(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }
        abstract public double eval();
    }
}
