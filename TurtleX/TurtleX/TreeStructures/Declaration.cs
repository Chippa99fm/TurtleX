using System;
using System.Drawing.Printing;
using TurtleLibrary;
using TurtleX.ParsersX;

namespace TurtleX.Interpreter
{
    public class Declaration : IExpression
    {
        private Boolean isCashed = false;
        private double result;

        public Declaration(String var, IExpression expr)
        {
            this.var = var;
            this.expr = expr;
        } 

        private String var;
        private IExpression expr;

        public double eval()
        {
            if (!isCashed)
            {
                result = expr.eval();
                Enviroment.getInstance().getVariables()[var] = result;
                isCashed = true;
            }

            return result;
        }
    }
}