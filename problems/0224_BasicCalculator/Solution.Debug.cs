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

        private static void PrintLexemes(IEnumerable<Lexeme> lexemes) {
            Console.Write(" ");

            foreach (var lexeme in lexemes) {
                Console.Write(" {0}", lexeme);
            }

            Console.WriteLine();
        }

        private static void PrintTree(Node node, int level) {
            for (var i = 0; i < level; i++) {
                Console.Write("  ");
            }

            Console.Write(node);

            Console.Write(" [");

            Console.Write(node.Evaluate());

            Console.WriteLine("]");

            if (node is Expression e) {
                PrintTree(e.Left, level + 1);
                PrintTree(e.Right, level + 1);
            } else if (node is ParenthesesNode p) {
                PrintTree(p.Inner, level + 1);
            }
        }

        private partial class Lexeme {

            public override string ToString() => String.Format("[{0}]", GetType().Name);

        }

        private partial class NumberLexeme {

            public override string ToString() => String.Format("[{0}:{1}]", GetType().Name, Value);

        }

        private partial class ValueNode {

            public override string ToString() => String.Format("ValueNode={0}", m_Value);

        }

        private partial class MulExpression {

            public override string ToString() => "MulExpression";

        }

        private partial class DivExpression {

            public override string ToString() => "DivExpression";

        }
        private partial class AddExpression {

            public override string ToString() => "AddExpression";

        }

        private partial class SubExpression {

            public override string ToString() => "SubExpression";

        }

        private partial class ParenthesesNode {

            public override string ToString() => "ParenthesesNode";

        }

        private partial class LexemeStream {

            public override string ToString() {
                var sb = new StringBuilder();

                for (int i = m_Position; i < m_Lexemes.Length; i++) {
                    if (sb.Length > 0) {
                        sb.Append(" ");
                    }

                    sb.AppendFormat("{0}:{1}", i, m_Lexemes[i]);
                }

                return sb.ToString();
            }

        }

    }
}
