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
        public static void addKostil()
        {
            OperatorFactory.operatorRegister.Add("/", (ie1, ie2) => { return new OperatorDivision(ie1, ie2); });
        }

        public OperatorDivision(IExpression left, IExpression right)
               : base(left, right)
        {
            // do nothing
        }
        public override double eval()
        {
            double leftValue = this.left.eval();
            double rightValue = this.right.eval();
            return leftValue / rightValue;
        }
    }
}
