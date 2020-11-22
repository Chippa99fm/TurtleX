using System;
using TurtleX.ParsersX;

namespace TurtleX.Interpreter
{
    public class Variable : IExpression
    {
        public Variable(Token variableName)
        {
            variable = variableName.getValue();
        }
        
        private String variable;
        public double eval()
        {
            if (!Enviroment.getInstance().getVariables().TryGetValue(variable, out var result))
            {
                throw new Exception("Can't resolve variable name");
            }
            return result;
        }
    }
}