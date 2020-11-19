using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurtleX.Interpreter;

namespace TurtleTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void simple_plus_test()
        {
            IExpression l1 = new Literal(8);
            IExpression l2 = new Literal(2);
            IExpression e1 = new OperatorPlus(l1, l2);

            Assert.AreEqual(10, e1.eval());
        }

        [TestMethod]
        public void simple_minus_test()
        {
            IExpression l1 = new Literal(8);
            IExpression l2 = new Literal(2);
            IExpression e1 = new OperatorMinus(l1, l2);

            Assert.AreEqual(6, e1.eval());
        }

        [TestMethod]
        public void simple_multiply_test()
        {
            IExpression l1 = new Literal(8);
            IExpression l2 = new Literal(2);
            IExpression e1 = new OperatorMultiply(l1, l2);

            Assert.AreEqual(16, e1.eval());
        }

        [TestMethod]
        public void simple_division_test()
        {
            IExpression l1 = new Literal(8);
            IExpression l2 = new Literal(2);
            IExpression e1 = new OperatorDivision(l1, l2);

            Assert.AreEqual(4, e1.eval());
        }
    }
}