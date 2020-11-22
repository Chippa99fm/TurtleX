using System;
using System.Collections;
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
		public List<Token> getTokens(String source)
		{
			Tokenizer tokenizer = new Tokenizer(source);
			return tokenizer.scanTokens();
		}

		/// <summary>
		/// Перевод токенов в постфиксную форму(Алгоритм Дейкстра)
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public List<Token> ToPostfix(List<Token> inputTokens)
		{
			Stack<Token> tokensStack = new Stack<Token>();
			List<Token> outputTokens = new List<Token>();

			if (inputTokens[0].getTokenType() == TokenType.VAR && inputTokens[1].getTokenType() == TokenType.EQUAL)
			{
				inputTokens.RemoveAt(0);
				inputTokens.RemoveAt(0);
			}

			inputTokens.ForEach((it) =>
			{
				TokenType type = it.getTokenType();
				switch (type)
				{
					case TokenType.LITERAL:
						outputTokens.Add(it);
						break;
					case TokenType.VAR:
						outputTokens.Add(it);
						break;
					case TokenType.LEFT_BRACE:
						tokensStack.Push(it);
						break;
					case TokenType.RIGHT_BRACE:
						rightBreaceHanlde(tokensStack, outputTokens);
						break;
					case TokenType.OPERATOR:
						operatorHandle(it, tokensStack, outputTokens);
						break;
				}
			});
			clearStack(tokensStack, outputTokens);

			return outputTokens;
		}

		private static void clearStack(Stack<Token> tokensStack, List<Token> outputTokens)
		{
			Token endToken;
			while (tokensStack.Count != 0)
			{
				endToken = tokensStack.Pop();
				if (endToken.getTokenType() == TokenType.LEFT_BRACE || endToken.getTokenType() == TokenType.RIGHT_BRACE)
				{
					throw new Exception("Invalid brace");
				}
				else
				{
					outputTokens.Add(endToken);
				}
			}
		}

		private static void operatorHandle(Token it, Stack<Token> tokensStack, List<Token> outputTokens)
		{
			if (tokensStack.Count == 0)
			{
				tokensStack.Push(it);
				return;
			}
			Token topToken = tokensStack.Peek();
			if (topToken.getTokenType() == TokenType.OPERATOR &&
			topToken.priority >= it.priority
			)
			{
				outputTokens.Add(tokensStack.Pop());
				tokensStack.Push(it);
			}
			else
			{
				tokensStack.Push(it);
			}
		}

		private static void rightBreaceHanlde(Stack<Token> tokensStack, List<Token> outputTokens)
		{
			Token token = null;
			while (tokensStack.Count != 0)
			{
				token = tokensStack.Pop();
				if (token.getTokenType() != TokenType.LEFT_BRACE)
				{
					outputTokens.Add(token);
				}
				else break;
			}
			if (token.getTokenType() != TokenType.LEFT_BRACE)
				throw new Exception("Invalid brace");
		}

		/// <summary>
		/// Построения дерева
		/// </summary>
		/// <param name="postfix"></param>
		/// <returns></returns>
		public IExpression BuildTree(List<Token> postfix)
		{
			return null;
		}

		public IExpression parse(String str)
		{
			List<Token> tokens = getTokens(str);
			List<Token> postfixTokens = ToPostfix(tokens);

			return BuildTree(postfixTokens);
		}

	}
}
