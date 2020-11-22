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
        public void simple_tokenizer_test()
        {
            String source = "x = 2.2 + 3";
            List<Token> expected = new List<Token>();
            expected.Add(new Token(TokenType.VAR, "x", 0, 1));
            expected.Add(new Token(TokenType.EQUAL, "=", 2, 1));
            expected.Add(new Token(TokenType.LITERAL, "2.2", 4, 3));
            expected.Add(new Token(TokenType.OPERATOR, "+", 8, 1));
            expected.Add(new Token(TokenType.LITERAL, "3", 10, 1));
            Tokenizer tokenizer = new Tokenizer(source);
            List<Token> actual = tokenizer.scanTokens();
            Assert.AreEqual(actual[0], expected[0]);
            Assert.AreEqual(actual.Count, expected.Count);
        }
    }
}