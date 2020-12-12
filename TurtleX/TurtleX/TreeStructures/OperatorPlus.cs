using System;
using TurtleLibrary;
using TurtleX.TreeStructures;

namespace TurtleX.Interpreter
{

    public class OperatorPlus : Operator
    {
        public static void add()
        {
            OperatorFactory.operatorRegister.Add("+", (ie1, ie2) => { return new OperatorPlus(ie1, ie2);}); 
        }
      
        public OperatorPlus(IExpression left, IExpression right)
            : base(left, right)
        {
            // do nothing
        }
        
        private Boolean isCashed = false;
        private double result;
        public override double eval()
        {
            if (!isCashed)
            {
                double leftValue = this.left.eval();
                double rightValue = this.right.eval();
                result =  leftValue + rightValue;
                isCashed = true;
            }

            return result;
        }
    }
}
