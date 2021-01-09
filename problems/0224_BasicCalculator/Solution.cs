using System;
using System.Collections.Generic;

namespace Quiz {
    public partial class Solution {

        private class Token {
            public Token(int start) {
                Start = start;
                Count = 1;
            }
            public int Start { get; }
            public int Count { get; private set; }
            public void Advance() => Count++;
        }
        
        private Token[] Tokenizer(string s) {
            List<Token> list = new List<Token>();

            Token pending = null;
            
            for (int i = 0; i < s.Length; i++) {
                char c = s[i];
                if (c == ' ') {
                    if (pending != null) {
                        list.Add(pending);
                        pending = null;
                    }
                } else if (c == '+' || c == '-' || c == '/' || c == '*' || c == '(' || c == ')') {
                    if (pending != null) {
                        list.Add(pending);
                        pending = null;
                    }
                    
                    list.Add(new Token(i));
                } else if (c >= '0' && c <= '9') {
                    if (pending != null) {
                        pending.Advance();
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
            
            return list.ToArray();
        }
        
        private partial class Lexeme { }
        private class OperationLexeme : Lexeme { }
        private class AddSubLexeme : OperationLexeme { }
        private class AddLexeme : AddSubLexeme { }
        private class SubLexeme : AddSubLexeme { }
        private class MulDivLexeme : OperationLexeme { }
        private class MulLexeme : MulDivLexeme { }
        private class DivLexeme : MulDivLexeme { }
        private class PLexeme : Lexeme { }
        private class OPLexeme : PLexeme { }
        private class CPLexeme : PLexeme { }
        
        private partial class NumberLexeme : Lexeme {
            public NumberLexeme(long value) => Value = value;
            public long Value { get; }
        }

        private Lexeme[] Lexer(string s, Token[] tokens) {
            List<Lexeme> list = new List<Lexeme>();
            Lexeme prev = null;

            bool negate_pending = false;
            
            foreach (Token token in tokens) {
                string ts = s.Substring(token.Start, token.Count);

                if (ts == "+" || ts == "-" || ts == "*" || ts == "/" || ts == "(" || ts == ")") {
                    if (negate_pending) {
                        throw new Exception("Lexer: Invalid token after negations");
                    }
                }

                Lexeme lexeme = null;
                if (ts == "+") {
                    lexeme = new AddLexeme();
                } else if (ts == "-") {
                    if (prev is OperationLexeme) {
                        negate_pending = true;
                    } else {
                        lexeme = new SubLexeme();        
                    }
                } else if (ts == "*") {
                    lexeme = new MulLexeme();
                } else if (ts == "/") {
                    lexeme = new DivLexeme();
                } else if (ts == "(") {
                    lexeme = new OPLexeme();
                } else if (ts == ")") {
                    lexeme = new CPLexeme();
                } else if (Int64.TryParse(ts, out long value)) {
                    if (negate_pending) {
                        lexeme = new NumberLexeme(-value);
                        negate_pending = false;
                    } else {
                        lexeme = new NumberLexeme(value);
                    }
                } else {
                    throw new Exception("Lexer: Invalid token");
                }

                if (lexeme != null) {
                    list.Add(lexeme);
                    prev = lexeme;
                }
            }

            return list.ToArray();
        }

        private partial class LexemeStream {

            public LexemeStream(Lexeme[] lexemes) {
                m_Position = 0;
                m_Lexemes = lexemes;
            }

            private int m_Position;

            private readonly Lexeme[] m_Lexemes;

            public bool EndReached => m_Position >= m_Lexemes.Length;

            public bool TryPeek<T>(int depth, out T lexeme) where T : Lexeme {
                int index = m_Position + depth - 1;
                if (index < m_Lexemes.Length) {
                    Lexeme l_o = m_Lexemes[index];
                    if (l_o is T l_t) {
                        lexeme = l_t;
                        return true;
                    }
                }
                lexeme = null;
                return false;
            }

            public void Advance(int steps) => m_Position += steps;

        }
        
        private abstract class Node {
            
            public abstract long Evaluate();
            
        }

        private partial class ValueNode : Node {

            public ValueNode(long value) => m_Value = value;

            private readonly long m_Value;

            public override long Evaluate() => m_Value;

        }

        private bool TryParseValue(LexemeStream stream, Stack<Node> stack) {
            if (!stream.TryPeek(1, out NumberLexeme lexeme)) {
                return false;
            }
            
            stream.Advance(1);

            stack.Push(new ValueNode(lexeme.Value));

            return true;
        }

        private abstract class Expression : Node {

            protected Expression(Node left, Node right) {
                Left = left;
                Right = right;
            }

            public Node Left { get; }

            public Node Right { get; }
            
        }

        private partial class MulExpression : Expression {

            public MulExpression(Node left, Node right) : base(left, right) { }

            public override long Evaluate() => Left.Evaluate() * Right.Evaluate();

        }

        private partial class DivExpression : Expression {

            public DivExpression(Node left, Node right) : base(left, right) { }

            public override long Evaluate() => Left.Evaluate() / Right.Evaluate();

        }

        private bool TryParseMulDiv(LexemeStream stream, Stack<Node> stack) {
            if (!stream.TryPeek(1, out MulDivLexeme lexeme)) {
                return false;
            }

            if (TryParseMulDiv_BeforeParentheses(stream, stack, lexeme)) {
                return true;
            }
            if (TryParseMulDiv_Simple(stream, stack, lexeme)) {
                return true;
            }

            return false;
        }

        private bool TryParseMulDiv_BeforeParentheses(LexemeStream stream, Stack<Node> stack, Lexeme lexeme) {
            if (!stream.TryPeek(2, out OPLexeme _)) {
                return false;
            }
            
            stream.Advance(1);

            if (TryParseParentheses(stream, stack)) {
                
            }

            if (!stack.TryPop(out Node r_value)) {
                throw new Exception("TryParseMulDiv_BeforeParentheses: RValue cant be obtained from stack");
            }

            if (!stack.TryPop(out Node l_value)) {
                throw new Exception("TryParseMulDiv_BeforeParentheses: LValue cant be obtained from stack");
            }

            if (lexeme is MulLexeme) {
                stack.Push(new MulExpression(l_value, r_value));
            } else if (lexeme is DivLexeme) {
                stack.Push(new DivExpression(l_value, r_value));
            } else {
                throw new Exception("TryParseMulDiv_BeforeParentheses: Lexeme is not supported");
            }

            return true;
        }

        private static bool TryParseMulDiv_Simple(LexemeStream stream, Stack<Node> stack, Lexeme lexeme) {
            if (!stream.TryPeek(2, out Lexeme r_lexeme)) {
                throw new Exception("TryParseMulDiv_Simple: RValue cant be obtained from token stream");
            }

            if (!(r_lexeme is NumberLexeme r_number)) {
                return false;
            }

            if (!stack.TryPop(out Node l_value)) {
                throw new Exception("TryParseMulDiv_Simple: LValue cant be obtained from stack");
            }

            stream.Advance(2);

            if (lexeme is MulLexeme) {
                stack.Push(new MulExpression(l_value, new ValueNode(r_number.Value)));
            } else if (lexeme is DivLexeme) {
                stack.Push(new DivExpression(l_value, new ValueNode(r_number.Value)));
            } else {
                throw new Exception("TryParseMulDiv_Simple: Lexeme is not supported");
            }

            return true;
        }

        private partial class AddExpression : Expression {

            public AddExpression(Node left, Node right) : base(left, right) { }

            public override long Evaluate() => Left.Evaluate() + Right.Evaluate();

        }

        private partial class SubExpression : Expression {

            public SubExpression(Node left, Node right) : base(left, right) { }

            public override long Evaluate() => Left.Evaluate() - Right.Evaluate();

        }

        private bool TryParseAddSub(LexemeStream stream, Stack<Node> stack) {
            if (!stream.TryPeek(1, out AddSubLexeme lexeme)) {
                return false;
            }
            
            if (TryParseAddSub_BeforeParentheses(stream, stack, lexeme)) {
                return true;
            }
            if (TryParseAddSub_BeforeMulDiv(stream, stack, lexeme)) {
                return true;
            }
            if (TryParseAddSub_Simple(stream, stack, lexeme)) {
                return true;
            }
            
            return false;
        }

        private bool TryParseAddSub_BeforeParentheses(LexemeStream stream, Stack<Node> stack, Lexeme lexeme) {
            if (!stream.TryPeek(2, out OPLexeme _)) {
                return false;
            }
            
            stream.Advance(1);

            if (TryParseParentheses(stream, stack)) {
                while (TryParseMulDiv(stream, stack)) {
                    
                }
            }

            if (!stack.TryPop(out Node r_value)) {
                throw new Exception("TryParseAddSub_BeforeParentheses: RValue cant be obtained from stack");
            }

            if (!stack.TryPop(out Node l_value)) {
                l_value = new ValueNode(0);
            }

            if (lexeme is AddLexeme) {
                stack.Push(new AddExpression(l_value, r_value));
            } else if (lexeme is SubLexeme) {
                stack.Push(new SubExpression(l_value, r_value));
            } else {
                throw new Exception("TryParseAddSub_BeforeParentheses: Lexeme is not supported");
            }

            return true;
        }

        private bool TryParseAddSub_BeforeMulDiv(LexemeStream stream, Stack<Node> stack, Lexeme lexeme) {
            if (!stream.TryPeek(3, out MulDivLexeme _)) {
                return false;
            }
            
            stream.Advance(1);

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

            if (lexeme is AddLexeme) {
                stack.Push(new AddExpression(l_value, r_value));
            } else if (lexeme is SubLexeme) {
                stack.Push(new SubExpression(l_value, r_value));
            } else {
                throw new Exception("TryParseAddSub_BeforeMulDiv: Lexeme is not supported");
            }

            return true;
        }

        private static bool TryParseAddSub_Simple(LexemeStream stream, Stack<Node> stack, Lexeme lexeme) {
            if (!stream.TryPeek(2, out Lexeme r_lexeme)) {
                throw new Exception("TryParseAddSub_Simple: RValue cant be obtained from token stream");
            }

            if (!(r_lexeme is NumberLexeme r_number)) {
                return false;
            }

            if (!stack.TryPop(out Node l_value)) {
                l_value = new ValueNode(0);
            }

            stream.Advance(2);

            if (lexeme is AddLexeme) {
                stack.Push(new AddExpression(l_value, new ValueNode(r_number.Value)));
            } else if (lexeme is SubLexeme) {
                stack.Push(new SubExpression(l_value, new ValueNode(r_number.Value)));
            } else {
                throw new Exception("TryParseAddSub_Simple: Lexeme is not supported");
            }

            return true;
        }

        private partial class ParenthesesNode : Node {

            public ParenthesesNode(Node inner) => Inner = inner;

            public Node Inner { get; }

            public override long Evaluate() => Inner.Evaluate();
            
        }

        private bool TryParseParentheses(LexemeStream stream, Stack<Node> stack) {
            if (!stream.TryPeek(1, out OPLexeme _)) {
                return false;
            }
            
            stream.Advance(1);

            while (true) {
                if (TryParseParentheses(stream, stack)) {
                    continue;
                }

                if (TryParseMulDiv(stream, stack)) {
                    continue;
                }

                if (TryParseAddSub(stream, stack)) {
                    continue;
                }

                if (TryParseValue(stream, stack)) {
                    continue;
                }

                if (stream.TryPeek(1, out CPLexeme _)) {
                    if (!stack.TryPop(out Node inner)) {
                        throw new Exception("TryParseParentheses: InnerValue cant be obtained from stack");
                    }

                    stream.Advance(1);
                    
                    stack.Push(new ParenthesesNode(inner));
                    
                    return true;
                } else {
                    throw new Exception("TryParseParentheses: Failed to parse CPLexeme");
                }
            }
        }

        private bool TryParseExpression(LexemeStream stream, Stack<Node> stack) {
            while (!stream.EndReached) {
                if (TryParseParentheses(stream, stack)) {
                    while (TryParseParentheses(stream, stack)) { }
                    continue;
                }
                
                if (TryParseMulDiv(stream, stack)) {
                    while (TryParseMulDiv(stream, stack)) { }
                    continue;
                }
                
                if (TryParseAddSub(stream, stack)) {
                    while (TryParseAddSub(stream, stack)) { }
                    continue;
                }
                
                if (TryParseValue(stream, stack)) {
                    continue;
                }
                
                throw new Exception("TryParseExpression: Cannot recognize pattern");
            }

            return stack.Count >= 1;
        }
        
        public int Calculate(string s) {
            Token[] tokens = Tokenizer(s);

            Lexeme[] lexemes = Lexer(s, tokens);
            
            // PrintLexemes(lexemes);

            LexemeStream stream = new LexemeStream(lexemes);

            Stack<Node> stack = new Stack<Node>();

            if (!TryParseExpression(stream, stack)) {
                throw new Exception("Calculate: Failed to parse expression");
            }

            Node root;
            if (!stack.TryPop(out root)) {
                throw new Exception("Calculate: Stack does not contain expression");
            }

            // PrintTree(root, 1);

            return (int)root.Evaluate();
        }
        
    }
}