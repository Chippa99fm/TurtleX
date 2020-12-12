using System;
using TurtleLibrary;
using TurtleX.TreeStructures;

namespace TurtleX.Interpreter
{
    public class OperatorMinus : Operator
    {
        public static void add()
        {
            OperatorFactory.operatorRegister.Add("-", (ie1, ie2) => { return new OperatorMinus(ie1, ie2); });
        }

        private Boolean isCashed = false;
        private double result;
        public OperatorMinus(IExpression left, IExpression right)
            :base(left,right)
        {
            
        }

        public override double eval()
        {
            if(!isCashed) {
                double leftValue = this.left.eval();
                double rightValue = this.right.eval();
                result =  leftValue - rightValue;
                isCashed = true;
            }

            return result;
        }
    }
}
