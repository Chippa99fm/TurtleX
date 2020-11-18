using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurtleX.Interpreter
{
    class Tokenizer
    {
        String source;
        List<Token> tokens = new List<Token>();
        private int start = 0;
        private int end = 0;
        private int line = 1;

        Dictionary<Token, String> tokenToLiteral = new Dictionary<Token, string>();

        public Tokenizer(String source)
        {
           
        } 
    }
}
