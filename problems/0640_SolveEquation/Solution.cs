using System;

namespace Quiz {
    public class Solution {

        public string SolveEquation(string equation) {
            if (String.IsNullOrEmpty(equation)) {
                return "No solution";
            }

            equation = equation.Replace(" ", String.Empty);

            string[] parts = equation.Split('=');
            if (parts.Length != 2) {
                return "No solution";
            }

            var co_x = 0;
            var co_n = 0;

            Parse(parts[0], ref co_x, ref co_n);

            co_x = -co_x;
            co_n = -co_n;

            Parse(parts[1], ref co_x, ref co_n);

            co_x = -co_x;

            if (co_x == 0) {
                if (co_n == 0) {
                    return "Infinite solutions";
                } else {
                    return "No solution";
                }
            }

            return String.Format("x={0}", co_n / co_x);
        }

        public void Parse(string expr, ref int co_x, ref int co_n) {
            var token = String.Empty;

            for (var i = 0; i < expr.Length; i++) {
                char c = expr[i];
                if (c >= '0' && c <= '9') {
                    token += c;
                } else if (c == '-') {
                    if (token.Length > 0) {
                        ParseToken(token, ref co_x, ref co_n);

                        token = String.Empty;
                    }

                    token += c;
                } else if (c == '+') {
                    if (token.Length > 0) {
                        ParseToken(token, ref co_x, ref co_n);

                        token = String.Empty;
                    }
                } else if (c == 'x') {
                    token += c;

                    ParseToken(token, ref co_x, ref co_n);

                    token = String.Empty;
                }
            }

            if (token.Length > 0) {
                ParseToken(token, ref co_x, ref co_n);
            }
        }

        private void ParseToken(string token, ref int co_x, ref int co_n) {
            // Console.WriteLine("    [{0}]", token);

            if (token.EndsWith("x")) {
                ParseToken(token.TrimEnd('x'), ref co_x);
            } else {
                ParseToken(token.TrimEnd('x'), ref co_n);
            }
        }

        private void ParseToken(string token, ref int co) {
            if (token == String.Empty) {
                token = "1";
            } else if (token == "-") {
                token = "-1";
            }

            // Console.WriteLine("      {0}", token);

            co += Int32.Parse(token);
        }

    }
}
