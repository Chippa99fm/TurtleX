using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurtleX.Interpreter;

namespace TurtleX.ParsersX
{
    public class ParserX
    {
        String source;

        public ParserX(String source)
        {
            this.source = source;
        }

        /// <summary>
        /// Перевож строки в токены
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public IEnumerable<Token> getTokens(String source)
        {
            return null;
        }

        /// <summary>
        /// Перевод токенов в постфиксную форму(Алгоритм Дейкстра)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public IEnumerable<Token> ToPostfix(IEnumerable<Token> input)
        {
            return null;
        }

        /// <summary>
        /// Построения дерева
        /// </summary>
        /// <param name="postfix"></param>
        /// <returns></returns>
        public IExpression BuildTree(IEnumerable<Token> postfix)
        {
            return null;
        }

        public IExpression parse(String str) {
            return null;
        }

    }
}
