using NUnit.Framework;
using System;
namespace Tests
{
	public class UnitTest1
	{
		[Test]
		public void plus_operator_test()
		{
			IExpression fExp = new Literal(2);
			IExpression sExp = new Literal(6);

			Operator plus = new OperatorPlus(fExp, sExp);
			double res = plus.eval();
			Assert.AreEqual(res, -4);
		}
	
	}
}
