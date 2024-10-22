using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public IList<int> DiffWaysToCompute(string input) {
            var tokens = Tokenize(input);

            var memo = new Dictionary<Tuple<int, int>, List<int>>();

            List<int> backtrace(int start, int end) {
                var key = new Tuple<int, int>(start, end);

                if (memo.TryGetValue(key, out var result)) {
                    return result;
                }

                result = new List<int>();

                if (start == end) {
                    if (tokens[start] is Number n) {
                        result.Add(n.Value);
                    } else {
                        throw new Exception("Not a number");
                    }
                } else {
                    for (int i = start; i <= end; i++) {
                        if (tokens[i] is Operation op) {
                            foreach (int l_value in backtrace(start, i - 1)) {
                                foreach (int r_value in backtrace(i + 1, end)) {
                                    result.Add(op.Func(l_value, r_value));
                                }
                            }

                            result.Sort();
                        }
                    }
                }

                memo[key] = result;

                return result;
            }

            return backtrace(0, tokens.Length - 1);
        }


        private class Token { }

        private class Number : Token {

            public int Value;

            public override string ToString() => Value.ToString();

        }

        private class Operation : Token {

            public char Char;

            public int Func(int x, int y) {
                switch (Char) {
                    case '+': return x + y;
                    case '-':return x - y;
                    case '*': return x * y;
                }
                return 0;
            }

            public override string ToString() => Char.ToString();

        }

        private Token[] Tokenize(string input) {
            var list = new List<Token>();

            int v_index = -1;
            var v_len = 0;

            for (var index = 0; index < input.Length; index++) {
                char c = input[index];
                if (c >= '0' && c <= '9') {
                    if (v_index >= 0) {
                        v_len++;
                    } else {
                        v_index = index;
                        v_len = 1;
                    }
                } else if (c == '+' || c == '-' || c == '*') {
                    if (v_index >= 0) {
                        list.Add(new Number { Value = Int32.Parse(input.Substring(v_index, v_len)) });

                        v_index = -1;
                        v_len = 0;

                        list.Add(new Operation { Char = c });
                    } else {
                        throw new Exception("Invalid char");
                    }
                } else {
                    throw new Exception("Invalid char");
                }
            }

            if (v_index >= 0) {
                list.Add(new Number { Value = Int32.Parse(input.Substring(v_index, v_len)) });
            }

            return list.ToArray();
        }

    }
}
