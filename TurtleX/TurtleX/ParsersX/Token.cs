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
        public int priority { get; set; }

        public Token(TokenType kind, string lexeme,  int pos, int length)
        {
            this.kind = kind;
            this.lexeme = lexeme;
            this.pos = pos;
            this.length = length;
        }

        public override String ToString()
        {
            return kind + " " + lexeme;
        }

        public TokenType  getTokenType()
        {
            return kind;
        }
    }

    public enum TokenType
    {
        WHITESPACE, LITERAL, OPERATOR, VAR, LEFT_BRACE, RIGHT_BRACE, EQUAL
    }
}
