﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurtleX.Interpreter
{
    public class OperatorMultiply : Operator
    {
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