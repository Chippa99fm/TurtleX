using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurtleX.Interpreter
{
    class Token
    {
        TokenType kind;
        String lexeme;
        Object literal;
        int line;
        
        public Token(TokenType kind, string lexeme, object literal, int line)
        {
            this.kind = kind;
            this.lexeme = lexeme;
            this.literal = literal;
            this.line = line;
        }

        public String toString()
        {
            return kind + " " + lexeme + " " + literal;
        }
    }
}
