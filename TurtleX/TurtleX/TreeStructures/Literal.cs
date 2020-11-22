using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurtleX.ParsersX;

namespace TurtleX.Interpreter
{
   public class Literal : IExpression
    {
        Token number;
        public Literal(Token number)
        {
            this.number = number;
        }
        public double eval()
        {
            return double.Parse(number.getValue());
        }
    }
}
