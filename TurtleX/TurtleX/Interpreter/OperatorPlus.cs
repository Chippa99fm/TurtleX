using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurtleX.Interpreter
{
    class OperatorPlus : Operator
    {
        public OperatorPlus(IExpression left, IExpression right)
            : base(left, right)
        {
            // do nothing
        }
        public double eval()
        {
            double leftValue = this.left.eval();
            double rightValue = this.right.eval();
            return leftValue + rightValue; 
        }
    }
}
