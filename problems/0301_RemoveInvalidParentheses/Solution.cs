using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz {
    public class Solution {
        
        public IList<string> RemoveInvalidParentheses(string s) {
            HashSet<string> hs = new HashSet<string>();

            int excess_op = 0;
            int excess_cp = 0;
            foreach (char c in s) {
                if (c == '(') {
                    excess_op++;
                } else if (c == ')') {
                    if (excess_op > 0) {
                        excess_op--;
                    } else {
                        excess_cp++;
                    }
                }
            }
            
            char[] buffer = new char[s.Length];
            void go_next(int s_index, int b_index, int op, int cp, int ballance) {
                while (s_index < s.Length) {
                    char c = s[s_index];
                    if (c == '(' || c == ')') {
                        break;
                    } else {
                        buffer[b_index] = c;
                        s_index++;
                        b_index++;
                    }
                }

                if (s_index < s.Length) {
                    char c = s[s_index];
                    if (c == '(') {
                        if (op > 0) {
                            go_next(s_index + 1, b_index, op - 1, cp, ballance);
                        }

                        buffer[b_index] = c;
                        go_next(s_index + 1, b_index + 1, op, cp, ballance + 1);
                    } else if (c == ')') {
                        if (cp > 0) {
                            go_next(s_index + 1, b_index, op, cp - 1, ballance);
                        }

                        buffer[b_index] = c;
                        go_next(s_index + 1, b_index + 1, op, cp, Math.Max(0, ballance - 1));
                    }
                } else if (op == 0 && cp == 0 && ballance == 0) {
                    hs.Add(new string(buffer, 0, b_index));
                }
            }

            go_next(0, 0, excess_op, excess_cp, 0);
            
            return hs.ToArray();
        }
        
    }
}