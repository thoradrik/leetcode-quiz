using System;
using System.Collections.Generic;

namespace Quiz {
    public partial class Solution {
        
        public int Calculate(string s) {
            List<Token> tokens = Tokenize(s);

            PrintTokens(tokens);
            
            Lexer(s, tokens);
            
            PrintTokens(tokens);

            Stack<Node> stack = new Stack<Node>();

            if (!TryParseExpression(new TokenStream(tokens), stack)) {
                throw new Exception("Failed to parse expression");
            }

            Node node;
            if (!stack.TryPop(out node)) {
                throw new Exception("Stack does not contain expression");
            }

            PrintExpressionTree(node, 1);

            return node.Evaluate();
        }

        private enum TokenType {
            None,
            Number,
            Add,
            Sub,
            Mul,
            Div
        }
        
        private partial class Token {

            public Token(int start) {
                Start = start;
                Count = 1;
            }

            public int Start { get; }
            
            public int Count { get; set; }

            public TokenType Type { get; set; }

            public int Value { get; set; }

            public bool IsNumber => Type == TokenType.Number;
            
            public bool IsOperation => Type == TokenType.Add || Type == TokenType.Sub || Type == TokenType.Mul || Type == TokenType.Div;
            
        }

        private List<Token> Tokenize(string s) {
            List<Token> list = new List<Token>();
            
            Token pending = null;
            
            for (int i = 0; i < s.Length; i++) {
                char c = s[i];
                if (c == ' ') {
                    if (pending != null) {
                        list.Add(pending);
                        pending = null;
                    }
                } else if (c == '+' || c == '-' || c == '/' || c == '*') {
                    if (pending != null) {
                        list.Add(pending);
                        pending = null;
                    }
                    
                    list.Add(new Token(i));
                } else if (c >= '0' && c <= '9') {
                    if (pending != null) {
                        pending.Count++;
                    } else {
                        pending = new Token(i);
                    }
                } else {
                    throw new Exception("Tokenize: Unexpected symbol");
                }
            }
            
            if (pending != null) {
                list.Add(pending);
            }
            
            return list;
        }

        private void Lexer(string s, List<Token> tokens) {
            Token prev = null;
            
            foreach (Token token in tokens) {
                string ts = s.Substring(token.Start, token.Count);

                if (ts == "+") {
                    token.Type = TokenType.Add;
                } else if (ts == "-") {
                    token.Type = TokenType.Sub;
                } else if (ts == "*") {
                    token.Type = TokenType.Mul;
                } else if (ts == "/") {
                    token.Type = TokenType.Div;
                } else if (Int32.TryParse(ts, out int value)) {
                    token.Type = TokenType.Number;
                    token.Value = value;
                } else {
                    throw new Exception("Lexer: Invalid token");
                }

                if (prev != null) {
                    if (prev.IsOperation && token.IsOperation) {
                        throw new Exception("Lexer: Several operations in a row");
                    } else if (prev.IsNumber && token.IsNumber) {
                        throw new Exception("Lexer: Several operations in a row");
                    }
                } else {
                    if (token.IsOperation) {
                        throw new Exception("Lexer: Trailing operation");
                    }
                }
                
                prev = token;
            }
        }

        private abstract class Node {

            public abstract int Evaluate();

        }

        private abstract class Expression : Node {

            protected Expression(Node left, Node right) {
                Left = left;
                Right = right;
            }

            public Node Left { get; }
            
            public Node Right { get; }
        }

        private partial  class MulExpression : Expression {

            public MulExpression(Node left, Node right) : base(left, right) { }

            public override int Evaluate() => Left.Evaluate() * Right.Evaluate();

        }

        private partial  class DivExpression : Expression {

            public DivExpression(Node left, Node right) : base(left, right) { }

            public override int Evaluate() => Left.Evaluate() / Right.Evaluate();

        }

        private partial class SubExpression : Expression {

            public SubExpression(Node left, Node right) : base(left, right) { }

            public override int Evaluate() => Left.Evaluate() - Right.Evaluate();

        }

        private partial class AddExpression : Expression {

            public AddExpression(Node left, Node right) : base(left, right) { }

            public override int Evaluate() => Left.Evaluate() + Right.Evaluate();

        }

        private partial class ValueExpression : Node {

            public ValueExpression(int value) {
                m_Value = value;
            }

            private readonly int m_Value;

            public override int Evaluate() => m_Value;

        }

        private partial class TokenStream {

            public TokenStream(List<Token> tokens) {
                m_Position = 0;
                m_Tokens = tokens;
            }

            private int m_Position;

            private readonly List<Token> m_Tokens;

            public bool EndReached => m_Position >= m_Tokens.Count;

            public bool TryPeek(int depth, out Token token) {
                if (m_Tokens.Count - m_Position >= depth) {
                    token = m_Tokens[m_Position + depth - 1];
                    return true;
                } else {
                    token = null;
                    return false;
                }
            }

            public void Pop(int steps = 1) {
                m_Position += steps;
            }
            
        }

        private bool TryParseExpression(TokenStream stream, Stack<Node> stack) {
            while (!stream.EndReached) {
                if (TryParseValue(stream, stack)) {
                    continue;
                }
                if (TryParseMulDiv(stream, stack)) {
                    while (TryParseMulDiv(stream, stack)) {
                        
                    }
                    continue;
                }
                if (TryParseAddSub(stream, stack)) {
                    while (TryParseAddSub(stream, stack)) {
                        
                    }
                    continue;
                }
                
                throw new Exception("TryParseExpression: Cannot recognize pattern");
            }

            return stack.Count >= 1;
        }

        private bool TryParseValue(TokenStream stream, Stack<Node> stack) {
            if (stream.TryPeek(1, out Token token)) {
                if (token.IsNumber) {
                    stream.Pop();
                    stack.Push(new ValueExpression(token.Value));
                
                    return true;
                }
            }
            
            return false;
        }

        private bool TryParseMulDiv(TokenStream stream, Stack<Node> stack) {
            if (stream.TryPeek(1, out Token op)) {
                if (op.Type == TokenType.Mul || op.Type == TokenType.Div) {
                    if (TryParseMulDiv_Simple(stream, stack, op)) {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool TryParseMulDiv_Simple(TokenStream stream, Stack<Node> stack, Token op) {
            if (!stream.TryPeek(2, out Token r_token)) {
                throw new Exception("TryParseMulDiv_Simple: RValue cant be obtained from token stream");
            }

            if (!r_token.IsNumber) {
                return false;
            }

            if (!stack.TryPop(out Node l_value)) {
                throw new Exception("TryParseMulDiv_Simple: LValue cant be obtained from stack");
            }

            stream.Pop(2);

            ValueExpression r_value = new ValueExpression(r_token.Value);
            if (op.Type == TokenType.Mul) {
                stack.Push(new MulExpression(l_value, r_value));
            } else {
                stack.Push(new DivExpression(l_value, r_value));
            }

            return true;
        }

        private bool TryParseAddSub(TokenStream stream, Stack<Node> stack) {
            if (stream.TryPeek(1, out Token op)) {
                if (op.Type == TokenType.Add || op.Type == TokenType.Sub) {
                    if (TryParseAddSub_BeforeMulDiv(stream, stack, op)) {
                        return true;
                    }
                    if (TryParseAddSub_Simple(stream, stack, op)) {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool TryParseAddSub_BeforeMulDiv(TokenStream stream, Stack<Node> stack, Token op) {
            if (!stream.TryPeek(3, out Token next_op)) {
                return false;
            }

            if (next_op.Type != TokenType.Mul && next_op.Type != TokenType.Div) {
                return false;
            }
            
            stream.Pop();

            if (TryParseValue(stream, stack)) {
                while (TryParseMulDiv(stream, stack)) {
                    
                }
            }

            if (!stack.TryPop(out Node r_value)) {
                throw new Exception("TryParseAddSub_BeforeMulDiv: RValue cant be obtained from stack");
            }

            if (!stack.TryPop(out Node l_value)) {
                throw new Exception("TryParseAddSub_BeforeMulDiv: LValue cant be obtained from stack");
            }

            if (op.Type == TokenType.Add) {
                stack.Push(new AddExpression(l_value, r_value));
            } else {
                stack.Push(new SubExpression(l_value, r_value));
            }

            return true;
        }

        private static bool TryParseAddSub_Simple(TokenStream stream, Stack<Node> stack, Token op) {
            if (!stream.TryPeek(2, out Token r_token)) {
                throw new Exception("TryParseAddSub_Simple: RValue cant be obtained from token stream");
            }

            if (!r_token.IsNumber) {
                return false;
            }
            
            if (!stack.TryPop(out Node l_value)) {
                throw new Exception("TryParseAddSub_Simple: LValue cant be obtained from stack");
            }

            stream.Pop(2);

            ValueExpression r_value = new ValueExpression(r_token.Value);
            if (op.Type == TokenType.Add) {
                stack.Push(new AddExpression(l_value, r_value));
            } else {
                stack.Push(new SubExpression(l_value, r_value));
            }

            return true;
        }

    }
}