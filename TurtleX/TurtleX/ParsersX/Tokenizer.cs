using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurtleX.ParsersX
{
    public class Tokenizer
    {
        String source;
        int current = 0;
        int start = 0;
        List<Token> tokens = new List<Token>();

        Dictionary<Char, int> prioritys = new Dictionary<char, int>();

        public Tokenizer(String source) {
            this.source = source;
            initPriority();
        }

        public List<Token> scanTokens() {
            while(!isAtEnd()) {
                start = current;
                scanToken();
            }

            return this.tokens;
        }

        private void initPriority() {
            prioritys.Add('+', 1);
            prioritys.Add('-', 1);
            prioritys.Add('*', 2);
            prioritys.Add('/', 2);
        }

        void scanToken() {
            char c = advance();
            switch (c) {
                case ')': 
                    addToken(TokenType.RIGHT_BRACE); 
                    break;
                case '(': 
                    addToken(TokenType.LEFT_BRACE);
                    break;
                case '=':
                    addToken(TokenType.EQUAL);
                    break;
                case ' ':
                    break;
                case '+':
                case '-':
                case '/':
                case '*':
                    addToken(TokenType.OPERATOR);
                    break;
                default:
                    if(isDigit(c)){
                        number();
                    } else if(isAlpha(c)) {
                        identifier();
                    }
                    else
                    {
                        throw new ArgumentException("Invalid character[start index - " + current + "| invalid character - " + source[current-1] + "]");
                    }
                    break;
            }
        }

        Boolean isDigit(char c)
        {
            return c >= '0' && c <= '9';
        }

        Boolean isAlpha(char c) {
            return (c >= 'a' && c <= 'z') ||
                (c >= 'A' && c <= 'Z') ||
                c == '_';
        }

        Boolean isAlphaNumeric(char c) {
            return isAlpha(c) || isDigit(c);
        }
        

        char advance() {
            return source[current++];
        }

        char prev()
        {
            return source[current - 1];
        }

        void number() {
            while (isDigit(peek()))
            {
                advance();
            }

            if(peek() == ',' && isDigit(peekNext())) {
                advance();
                while (isDigit(peek()))
                {
                    advance();
                }
            }

            addToken(TokenType.LITERAL);
        }

        void identifier() {
            TokenType tokenType = TokenType.VAR;
            if(prev() == '_') {
                tokenType = TokenType.OPERATOR;
            } 
            while(isAlphaNumeric(peek())) {
                if (isDigit(peek()) && tokenType == TokenType.OPERATOR)
                {
                    break;
                }
                advance();
            }
            addToken(tokenType);
        }

        private char peek() {
            if (isAtEnd()) return '\0';
            return source[current];
        }   

        void addToken(TokenType tokenType) {
            String text = source.Substring(start, current - start);
            Token token = new Token(tokenType, text, start, current - start);
            if (tokenType == TokenType.OPERATOR)
            {
                int priority = 0;
                if (!prioritys.TryGetValue(text.ToCharArray()[0], out priority))
                {
                    priority = 3;
                }
                token.priority = priority;
            }
            tokens.Add(token);
        }

        private Boolean isAtEnd() {
            return current >= source.Length;
        }

        private char peekNext() {
            if (current + 1 >= source.Length) return '\0';
            return source[current + 1];
        }
    }
}
