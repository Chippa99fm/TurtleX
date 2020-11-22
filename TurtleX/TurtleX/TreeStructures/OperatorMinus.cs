using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurtleLibrary;

namespace TurtleX.Interpreter
{
    public class OperatorMinus : Operator
    {

        static OperatorMinus() {
            OperatorFactory.operatorRegister.Add("-", (ie1, ie2) => { return new OperatorMinus(ie1, ie2); });
        }
        public OperatorMinus(IExpression left, IExpression right)
            :base(left,right)
        {
            
        }

        public override double eval()
        {
            double leftValue = this.left.eval();
            double rightValue = this.right.eval();
            return leftValue - rightValue;
        }
    }
}
