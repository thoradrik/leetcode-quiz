using System;

namespace Quiz {
    public class Solution {
        
        public int MaxDepth(string s) {
            int max_depth = 0;
            int depth = 0;
            
            foreach (char c in s) {
                if (c == '(') {
                    depth++;
                    max_depth = Math.Max(max_depth, depth);
                } else if (c == ')') {
                    depth--;
                }
            }

            return max_depth;
        }
        
    }
}