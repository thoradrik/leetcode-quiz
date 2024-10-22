using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public string ReverseParentheses(string s) {
            List<char> Recursive(int start, out int stop) {
                var result = new List<char>();

                for (stop = start + 1; stop < s.Length; stop++) {
                    char c = s[stop];
                    if (c == '(') {
                        var sub = Recursive(stop, out stop);
                    
                        sub.Reverse();
                    
                        result.AddRange(sub);
                    } else if (c == ')') {
                        break;
                    } else {
                        result.Add(c);
                    }
                }

                return result;
            }
            
            return String.Concat(Recursive(-1, out _));
        }

    }
}