using System;

namespace Quiz {
    public class Solution {

        public int LongestValidParentheses(string s) {
            var flags = new bool[s.Length];
            var max = 0;

            for (var end = 1; end < s.Length; end++) {
                int start = end - 1;
                if (s[start] == '(' && s[end] == ')') {
                    flags[start] = true;
                    flags[end] = true;
                }

                bool expanded;
                do {
                    expanded = false;

                    while (start >= 0 && flags[start]) {
                        start--;
                        expanded = true;
                    }
                    while (end < s.Length && flags[end]) {
                        end++;
                        expanded = true;
                    }
                    while (start >= 0 && s[start] == '(' && end < s.Length && s[end] == ')') {
                        flags[start] = true;
                        start--;

                        flags[end] = true;
                        end++;

                        expanded = true;
                    }
                } while (expanded);

                max = Math.Max(max, end - start - 1);
            }

            return max;
        }

    }
}
