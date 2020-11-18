using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurtleX.Interpreter
{
    enum TokenType
    {
        EQUAL, ADD, SUBSTRACT, MULTIPLY, DIVIDE, FUNCTION,
        LITERAL, VARIABLE, EOF
    }
}
