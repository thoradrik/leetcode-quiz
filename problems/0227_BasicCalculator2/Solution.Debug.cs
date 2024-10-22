using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz {
    public partial class Solution {

        private static void PrintTokens(IEnumerable<Token> tokens) {
            Console.Write(" ");

            foreach (var token in tokens) {
                Console.Write(" {0}", token);
            }

            Console.WriteLine();
        }

        private static void PrintExpressionTree(Node node, int level) {
            for (var i = 0; i < level; i++) {
                Console.Write("  ");
            }

            Console.WriteLine(node);

            if (node is Expression e) {
                PrintExpressionTree(e.Left, level + 1);
                PrintExpressionTree(e.Right, level + 1);
            }
        }

        private partial class Token {

            public override string ToString() {
                if (Type == TokenType.None) {
                    return string.Format("[{0}+{1}]", Start, Count);
                } else if (Type == TokenType.Number) {
                    return string.Format("[{0}:{1}]", Type, Value);
                } else {
                    return string.Format("[{0}]", Type);
                }
            }

        }

        private partial class MulExpression {

            public override string ToString() => "MultiplyExpression";

        }

        private partial class DivExpression {

            public override string ToString() => "DivExpression";

        }

        private partial class SubExpression {

            public override string ToString() => "SubExpression";

        }

        private partial class AddExpression {

            public override string ToString() => "AddExpression";

        }

        private partial class ValueExpression {

            public override string ToString() => String.Format("ValueExpression={0}", m_Value);

        }

        private partial class TokenStream {

            public override string ToString() {
                var sb = new StringBuilder();

                for (int i = m_Position; i < m_Tokens.Count; i++) {
                    if (sb.Length > 0) {
                        sb.Append(" ");
                    }

                    sb.AppendFormat("{0}:{1}", i, m_Tokens[i]);
                }

                return sb.ToString();
            }

        }

    }
}
