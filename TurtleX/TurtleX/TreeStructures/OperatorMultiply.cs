using System;
using TurtleLibrary;
using TurtleX.TreeStructures;

namespace TurtleX.Interpreter
{
    public class OperatorMultiply : Operator
    {
        public static void add() {
            OperatorFactory.operatorRegister.Add("*", (ie1, ie2) => { return new OperatorMultiply(ie1, ie2); });
        }
        public OperatorMultiply(IExpression left, IExpression right)
            : base(left, right)
        {

        }
        
        private Boolean isCashed = false;
        private double result;

        public override double eval()
        {
            if (!isCashed)
            {
                double leftValue = this.left.eval();
                double rightValue = this.right.eval();
                result =  leftValue * rightValue;
                isCashed = true;
            }

            return result;
        }
    }
}
