using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurtleX.Interpreter
{
    class MultiplyOperator : Operator
    {
        public MultiplyOperator(IExpression left, IExpression right)
            : base(left, right)
        {

        }

        public double eval()
        {
            double leftValue = this.left.eval();
            double rightValue = this.right.eval();
            return leftValue * rightValue;
        }
    }
}
