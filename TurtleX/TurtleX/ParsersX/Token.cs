using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurtleX.ParsersX
{
    public class Token : IEquatable<Token>
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

        public Token(TokenType kind, string lexeme, int pos, int length, int priority)
        {
            this.kind = kind;
            this.lexeme = lexeme;
            this.pos = pos;
            this.length = length;
            this.priority = priority;
        }

        public override String ToString()
        {
            return kind + " " + lexeme;
        }

        public TokenType  getTokenType()
        {
            return kind;
        }
        public String getValue()
        {
            return lexeme;
        }

        public bool Equals(Token other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return kind == other.kind && lexeme == other.lexeme 
                                      && pos == other.pos && length == other.length 
                                      && priority == other.priority;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Token) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (int) kind;
                hashCode = (hashCode * 397) ^ (lexeme != null ? lexeme.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ pos;
                hashCode = (hashCode * 397) ^ length;
                hashCode = (hashCode * 397) ^ priority;
                return hashCode;
            }
        }
    }

    public enum TokenType
    {
        WHITESPACE, LITERAL, OPERATOR, VAR, LEFT_BRACE, RIGHT_BRACE, EQUAL, COMMA
    }
}
