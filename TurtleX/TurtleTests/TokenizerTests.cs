using System;
using System.Collections.Generic;
using System.Text;
using TurtleX.Interpreter;
using TurtleX.ParsersX;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TurtleTests
{
    [TestClass]
    class TokenizerTests
    {
        [TestMethod]
        public void simple_tokenizer_test()
        {
            string source = "X = 2 + 5 - 2";
            List<Token> expected = new List<Token>();
          //  Assert.areEqual(1, 1);
        }
    }
}
