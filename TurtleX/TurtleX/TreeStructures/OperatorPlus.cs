using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurtleLibrary;

namespace TurtleX.Interpreter
{

    public class OperatorPlus : Operator
    {
        static OperatorPlus() { 
            OperatorFactory.operatorRegister.Add("+", (ie1, ie2) => { return new OperatorPlus(ie1, ie2);}); 
        }
      
        public OperatorPlus(IExpression left, IExpression right)
            : base(left, right)
        {
            // do nothing
        }
        public override double eval()
        {
            double leftValue = this.left.eval();
            double rightValue = this.right.eval();
            return leftValue + rightValue; 
        }
    }
}
