using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TurtleX.Interpreter;
using TurtleX.ParsersX;

namespace TurtleTests
{
    [TestClass]
    class ParserTests
    {
        [TestMethod]
        public void parser_test()
        {
            String s = "2+2*5";
            ParserX parser = new ParserX(s);
            parser.parse(s);
        }

        private IExpression buildTree()
        {
            IExpression e1 = null;
            return e1;
        }
    }
}
