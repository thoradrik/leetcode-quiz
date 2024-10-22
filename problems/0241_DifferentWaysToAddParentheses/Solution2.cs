using System;
using System.Collections.Generic;
using AlgorithmLib;

namespace Quiz {
    public class Solution2 {

        public IList<int> DiffWaysToCompute(string input) {
            var results = new List<int>();

            var tokenized = Tokenize(input);

            PermutationGenerator.Generate(tokenized, tokens => {
                for (var i = 0; i < tokens.Length; i++) {
                    var token = tokens[i];
                    token.EvaluatedValue = null;
                }

                for (var i = 0; i < tokens.Length; i++) {
                    var token = tokens[i];

                    var prev = token.Prev;
                    int l_value = prev?.EvaluatedValue ?? token.LValue;

                    var next = token.Next;
                    int r_value = next?.EvaluatedValue ?? token.RValue;

                    token.EvaluatedValue = token.Op(l_value, r_value);

                    while (prev != null && prev.EvaluatedValue != null) {
                        prev.EvaluatedValue = token.EvaluatedValue;
                        prev = prev.Prev;
                    }
                    while (next != null && next.EvaluatedValue != null) {
                        next.EvaluatedValue = token.EvaluatedValue;
                        next = next.Next;
                    }

                    Console.Write(token);

                    if (i == tokens.Length - 1) {
                        results.Add(token.EvaluatedValue.Value);

                        Console.Write(" = ");
                        Console.Write(token.EvaluatedValue.Value);
                    } else {
                        Console.Write(" -> ");
                    }

                }

                Console.WriteLine();
            });

            results.Sort();

            return results;
        }


        private class Token {

            public Token Prev;

            public Token Next;

            public int LValue;

            public int RValue;

            public Func<int, int, int> Op;

            public char Char;

            public override string ToString() => String.Format("{0}{1}{2}", LValue, Char, RValue);

            public int? EvaluatedValue;

        }

        private Token[] Tokenize(string input) {
            var list = new List<Token>();

            int v_index = -1;
            var v_len = 0;

            for (var index = 0; index < input.Length; index++) {
                char c = input[index];
                if (c >= '0' && c <= '9') {
                    if (v_index > 0) {
                        v_len++;
                    } else {
                        v_index = index;
                        v_len = 1;
                    }
                } else if (c == '+' || c == '-' || c == '*') {
                    int value = Int32.Parse(input.Substring(v_index, v_len));

                    v_index = -1;
                    v_len = 0;

                    var prev = list.Count > 0 ? list[^1] : null;

                    var token = new Token {
                        Char = c,
                        Prev = prev,
                        LValue = value
                    };

                    switch (c) {
                        case '+':
                            token.Op = (x, y) => x + y;
                            break;
                        case '-':
                            token.Op = (x, y) => x - y;
                            break;
                        case '*':
                            token.Op = (x, y) => x * y;
                            break;
                    }

                    list.Add(token);

                    if (prev != null) {
                        prev.Next = token;
                        prev.RValue = value;
                    }
                } else {
                    throw new Exception("Invalid char");
                }
            }

            if (v_index >= 0) {
                int value = Int32.Parse(input.Substring(v_index, v_len));

                if (list.Count > 0) {
                    var last = list[^1];
                    last.RValue = value;
                } else {
                    list.Add(new Token {
                        Char = '=',
                        RValue = value,
                        Op = (_,_) => value
                    });
                }
            }

            return list.ToArray();
        }

    }


}
