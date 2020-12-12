using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurtleLibrary;
using TurtleX.TreeStructures;

namespace TurtleX.Interpreter
{
    public class OperatorDivision: Operator
    {
        public static void add()
        {
            OperatorFactory.operatorRegister.Add("/", (ie1, ie2) => { return new OperatorDivision(ie1, ie2); });
        }

        private Boolean isCashed = false;
        private double result;

        public OperatorDivision(IExpression left, IExpression right)
               : base(left, right)
        {
            // do nothing
        }
        public override double eval()
        {
            if (!isCashed)
            {
                double leftValue = this.left.eval();
                double rightValue = this.right.eval();
                result = leftValue / rightValue;
                isCashed = true;
            }

            return result;
        }
    }
}
