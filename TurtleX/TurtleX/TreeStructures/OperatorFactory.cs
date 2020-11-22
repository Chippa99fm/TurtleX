using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurtleX.Interpreter;

namespace TurtleX.TreeStructures
{
	public static class OperatorFactory
	{
		public static Dictionary<String, Func<IExpression, IExpression, IExpression>> operatorRegister = initOperatorRegister();
			
		public static IExpression getExpression(String lexeme, IExpression leftExp, IExpression rightExp)
		{
			return operatorRegister[lexeme].Invoke(leftExp, rightExp);
		}

		public static Dictionary<String, Func<IExpression, IExpression, IExpression>> initOperatorRegister()
		{
			Dictionary<String, Func<IExpression, IExpression, IExpression>> e = new Dictionary<String, Func<IExpression, IExpression, IExpression>>();
			e.Add("+", (ie1, ie2) => { return new OperatorPlus(ie1, ie2); });
			e.Add("-", (ie1, ie2) => { return new OperatorMinus(ie1, ie2); });
			e.Add("/", (ie1, ie2) => { return new OperatorDivision(ie1, ie2); });
			e.Add("*", (ie1, ie2) => { return new OperatorMultiply(ie1, ie2); });
			return e;
		}
	}
}
