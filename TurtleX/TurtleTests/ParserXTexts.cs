using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TurtleLibrary;
using TurtleX.Interpreter;
using TurtleX.ParsersX;

namespace TurtleTests
{
    [TestClass]
    public class ParserXTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            ParserX.initOperators();
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

            ParserX parser = new ParserX();
            List<Token> tokens = parser.ToPostfix(expected);

            for (int i = 0; i < actual.Count; i++)
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

            ParserX parser = new ParserX();
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

            ParserX parser = new ParserX();
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

            ParserX parser = new ParserX();
            List<Token> tokens = parser.ToPostfix(expected);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(actual[i], tokens[i]);
            }
        }

        [TestMethod]
        public void simple_build_tree_test()
        {
            List<Token> expected = new List<Token>();
            expected.Add(new Token(TokenType.LITERAL, "2", 2, 2));
            expected.Add(new Token(TokenType.OPERATOR, "+", 2, 2));
            expected.Add(new Token(TokenType.LITERAL, "2", 2, 2));

            ParserX parser = new ParserX();
            List<Token> tokens = parser.ToPostfix(expected);
            IExpression exp = parser.BuildTree(tokens);

            Assert.AreEqual(4, exp.eval());
        }

        [TestMethod]
        public void medium_build_tree_test()
        {
            List<Token> expected = new List<Token>();
            expected.Add(new Token(TokenType.LITERAL, "2", 2, 2));
            expected.Add(new Token(TokenType.OPERATOR, "+", 2, 2,1));
            expected.Add(new Token(TokenType.LITERAL, "2", 2, 2));
            expected.Add(new Token(TokenType.OPERATOR, "*", 2, 2, 2));
            expected.Add(new Token(TokenType.LITERAL, "2", 2, 2));

            ParserX parser = new ParserX();
            List<Token> tokens = parser.ToPostfix(expected);
            IExpression exp = parser.BuildTree(tokens);

            Assert.AreEqual(6, exp.eval());
        }
    }
}
