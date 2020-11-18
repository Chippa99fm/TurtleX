using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurtleX.Interpreter
{
    class Literal : IExpression
    {
        double number;
        public Literal(double number)
        {
            this.number = number;
        }
        public double eval()
        {
            return number;
        }
    }
}
