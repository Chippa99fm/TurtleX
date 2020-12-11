﻿using TurtleLibrary;
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

        public override double eval()
        {
            double leftValue = this.left.eval();
            double rightValue = this.right.eval();
            return leftValue * rightValue;
        }
    }
}
