using System;
using System.Drawing.Printing;
using TurtleX.ParsersX;

namespace TurtleX.Interpreter
{
    public class Declaration : IExpression
    {

        public Declaration(String var, IExpression expr)
        {
            this.var = var;
            this.expr = expr;
        } 

        private String var;
        private IExpression expr;

        public double eval()
        {
            double result = expr.eval();
            Enviroment.getInstance().getVariables().Add(var, result);
            return result;
        }
    }
}