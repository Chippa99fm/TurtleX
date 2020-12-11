using System;
using System.Collections.Generic;
using TurtleLibrary;


namespace TurtleX.TreeStructures
{
	public static class OperatorFactory
	{
		public static Dictionary<String, Func<IExpression, IExpression, IExpression>> operatorRegister
			= new Dictionary<string, Func<IExpression, IExpression, IExpression>>();

		public static IExpression getExpression(String lexeme, IExpression leftExp, IExpression rightExp)
		{
			return operatorRegister[lexeme].Invoke(leftExp, rightExp);
		}
	}
}