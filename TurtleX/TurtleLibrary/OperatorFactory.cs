using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurtleLibrary
{
	public static class OperatorFactory
	{
		public static Dictionary<string, Func<IExpression, IExpression, IExpression>> operatorRegister
			= new Dictionary<string, Func<IExpression, IExpression, IExpression>>();

		public static IExpression getExpression(string lexeme, IExpression leftExp, IExpression rightExp)
		{
			return operatorRegister[lexeme].Invoke(leftExp, rightExp);
		}


	}
}
