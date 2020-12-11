using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurtleLibrary;
using TurtleX.TreeStructures;

namespace Kvadrat
{
	public class Kvadrat : Operator
	{
        public static void add()
        {
            OperatorFactory.operatorRegister.Add("^", (ie1, ie2) => { return new Kvadrat(ie1, ie2); });
        }

        public Kvadrat(IExpression left, IExpression right)
               : base(left, right)
        {
        }
        public override double eval()
        {
            double leftValue = this.left.eval();
            double rightValue = this.right.eval();
            return Math.Pow(leftValue, rightValue);
        }
    }
}
