using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurtleX.ParsersX;

namespace TurtleTests
{
    [TestClass]
    public class TokenizerTests
    {
        [TestMethod]
        public void SimpleTest()
        {
            String source = "x = 2.2 + 3";
            List<Token> expected = new List<Token>();
            expected.Add(new Token(TokenType.VAR, "x", 0, 1));
            expected.Add(new Token(TokenType.EQUAL, "=", 2, 1));
            expected.Add(new Token(TokenType.LITERAL, "2.2", 4, 3));
            Token op = new Token(TokenType.OPERATOR, "+", 8, 1);
            op.priority = 1;
            expected.Add(op);
            expected.Add(new Token(TokenType.LITERAL, "3", 10, 1));
            Tokenizer tokenizer = new Tokenizer(source);
            List<Token> actual = tokenizer.scanTokens();
            Assert.AreEqual(actual.Count, expected.Count);
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }

        [TestMethod]
        public void testPriority()
        {
            String source = "+-*/_op";
            List<Int32> expected = new List<int>();
            expected.Add(1);
            expected.Add(1);
            expected.Add(2);
            expected.Add(2);
            expected.Add(3);
            Tokenizer tokenizer = new Tokenizer(source);
            List<Token> actual = tokenizer.scanTokens();
            Assert.AreEqual(actual.Count, expected.Count);
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i].priority);
            } 
        }

        [TestMethod]
        public void testComplex()
        {
            String source = "x=1.674+3+_op(1,2)";
            List<Token> expected = new List<Token>();
            expected.Add(new Token(TokenType.VAR, "x", 0, 1));
            expected.Add(new Token(TokenType.EQUAL, "=", 1, 1));
            expected.Add(new Token(TokenType.LITERAL, "1.674", 2, 5));
            Token op1 = new Token(TokenType.OPERATOR, "+", 7, 1);
            op1.priority = 1;
            expected.Add(op1);
            expected.Add(new Token(TokenType.LITERAL, "3", 8, 1));
            Token op2 = new Token(TokenType.OPERATOR, "+", 9, 1);
            op2.priority = 1;
            expected.Add(op2);
            Token op3 = new Token(TokenType.OPERATOR, "_op", 10, 3);
            op3.priority = 3;
            expected.Add(op3);
            expected.Add(new Token(TokenType.LEFT_BRACE, "(", 13, 1));
            expected.Add(new Token(TokenType.LITERAL, "1", 14, 1));
            expected.Add(new Token(TokenType.COMMA, ",", 15, 1));
            expected.Add(new Token(TokenType.LITERAL, "2", 16, 1));
            expected.Add(new Token(TokenType.RIGHT_BRACE, ")", 17, 1));
            Tokenizer tokenizer = new Tokenizer(source);
            List<Token> actual = tokenizer.scanTokens();
            Assert.AreEqual(actual.Count, expected.Count);
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }
    }
}