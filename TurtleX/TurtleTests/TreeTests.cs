using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TurtleX.Interpreter;
using TurtleX.ParsersX;

namespace TurtleTests
{
    [TestClass]
    public class TreeTests
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

        [TestMethod]
        public void tree_test()
        {
            IExpression l1 = new Literal(8);
            IExpression l2 = new Literal(2);
            IExpression e1 = new OperatorPlus(l1, l2);

            IExpression e2 = new OperatorMinus(l1, l2);
            IExpression e3 = new OperatorMultiply(e1, e2);
            Assert.AreEqual(60, e3.eval());
        }

        [TestMethod]
        public void simple_postfix_transformate_test()
        {           
            List<Token> expected = new List<Token>();
            expected.Add(new Token(TokenType.LITERAL, "2", 2, 2));
            expected.Add(new Token(TokenType.OPERATOR, "2", 2, 2));
            expected.Add(new Token(TokenType.LITERAL, "2", 2, 2));

            List<Token> actual = new List<Token>();
            actual.Add(new Token(TokenType.LITERAL, "2", 2, 2));
            actual.Add(new Token(TokenType.LITERAL, "2", 2, 2));
            actual.Add(new Token(TokenType.OPERATOR, "2", 2, 2));

            ParserX parser = new ParserX("");
            List<Token> tokens = parser.ToPostfix(expected);

            for(int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(actual[i], tokens[i]);
            }          
        }

        [TestMethod]
        public void simple_postfix_transformate_brace_test()
        {
            List<Token> expected = new List<Token>();
            expected.Add(new Token(TokenType.LEFT_BRACE, "(", 2, 2));
            expected.Add(new Token(TokenType.LITERAL, "2", 2, 2));
            expected.Add(new Token(TokenType.OPERATOR, "*", 2, 2));
            expected.Add(new Token(TokenType.LITERAL, "3", 2, 2));
            expected.Add(new Token(TokenType.RIGHT_BRACE, ")", 2, 2));
            expected.Add(new Token(TokenType.OPERATOR, "/", 2, 2));
            expected.Add(new Token(TokenType.LITERAL, "1", 2, 2));

            List<Token> actual = new List<Token>();
            actual.Add(new Token(TokenType.LITERAL, "2", 2, 2));
            actual.Add(new Token(TokenType.LITERAL, "3", 2, 2));
            actual.Add(new Token(TokenType.OPERATOR, "*", 2, 2));
            actual.Add(new Token(TokenType.LITERAL, "1", 2, 2));
            actual.Add(new Token(TokenType.OPERATOR, "/", 2, 2));

            ParserX parser = new ParserX("");
            List<Token> tokens = parser.ToPostfix(expected);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(actual[i], tokens[i]);
            }
        }

        [TestMethod]
        public void medium_postfix_transformate_test()
        {
            List<Token> expected = new List<Token>();
            expected.Add(new Token(TokenType.LITERAL, "3", 2, 2, -1));
            expected.Add(new Token(TokenType.OPERATOR, "+", 2, 2, 1));
            expected.Add(new Token(TokenType.LITERAL, "4", 2, 2, -1));
            expected.Add(new Token(TokenType.OPERATOR, "*", 2, 2, 2));
            expected.Add(new Token(TokenType.LITERAL, "2", 2, 2, -1));
            expected.Add(new Token(TokenType.OPERATOR, "/", 2, 2, 2));
            expected.Add(new Token(TokenType.LEFT_BRACE, "(", 2, 2, -1));
            expected.Add(new Token(TokenType.LITERAL, "1", 2, 2, -1));
            expected.Add(new Token(TokenType.OPERATOR, "-", 2, 2, 1));
            expected.Add(new Token(TokenType.LITERAL, "5", 2, 2, -1));
            expected.Add(new Token(TokenType.RIGHT_BRACE, ")", 2, 2, -1));
            expected.Add(new Token(TokenType.OPERATOR, "^", 2, 2, 3));
            expected.Add(new Token(TokenType.LITERAL, "2", 2, 2, -1));

            List<Token> actual = new List<Token>();
            actual.Add(new Token(TokenType.LITERAL, "3", 2, 2, -1));
            actual.Add(new Token(TokenType.LITERAL, "4", 2, 2, -1));
            actual.Add(new Token(TokenType.LITERAL, "2", 2, 2, -1));
            actual.Add(new Token(TokenType.OPERATOR, "*", 2, 2, 2));
            actual.Add(new Token(TokenType.LITERAL, "1", 2, 2, -1));
            actual.Add(new Token(TokenType.LITERAL, "5", 2, 2, -1));
            actual.Add(new Token(TokenType.OPERATOR, "-", 2, 2, 1));
            actual.Add(new Token(TokenType.LITERAL, "2", 2, 2, -1));
            actual.Add(new Token(TokenType.OPERATOR, "^", 2, 2, 3));
            actual.Add(new Token(TokenType.OPERATOR, "/", 2, 2, 2));
            actual.Add(new Token(TokenType.OPERATOR, "+", 2, 2, 1));

            ParserX parser = new ParserX("");
            List<Token> tokens = parser.ToPostfix(expected);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(actual[i], tokens[i]);
            }
        }

        [TestMethod]
        public void simple_postfix_transformate_variable_test()
        {
            List<Token> expected = new List<Token>();
            expected.Add(new Token(TokenType.VAR, "X", 2, 2));
            expected.Add(new Token(TokenType.EQUAL, "=", 2, 2));
            expected.Add(new Token(TokenType.LITERAL, "2", 2, 2));
            expected.Add(new Token(TokenType.OPERATOR, "+", 2, 2));
            expected.Add(new Token(TokenType.LITERAL, "2", 2, 2));

            List<Token> actual = new List<Token>();
            actual.Add(new Token(TokenType.LITERAL, "2", 2, 2));
            actual.Add(new Token(TokenType.LITERAL, "2", 2, 2));
            actual.Add(new Token(TokenType.OPERATOR, "+", 2, 2));

            ParserX parser = new ParserX("");
            List<Token> tokens = parser.ToPostfix(expected);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(actual[i], tokens[i]);
            }
        }
    }
}
