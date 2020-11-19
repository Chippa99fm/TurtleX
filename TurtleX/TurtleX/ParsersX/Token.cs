using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurtleX.ParsersX
{
    public class Token
    {
        TokenType kind;
        String lexeme;
        int pos;
        int length;

        public Token(TokenType kind, string lexeme,  int pos, int length)
        {
            this.kind = kind;
            this.lexeme = lexeme;
            this.pos = pos;
            this.length = length;
        }

        public String toString()
        {
            return kind + " " + lexeme;
        }
    }

    public enum TokenType
    {
        WHITESPACE, LITERAL, OPERATOR, VAR, LEFT_BRACE, RIGHT_BRACE
    }
}
