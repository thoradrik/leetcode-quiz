using System;

namespace Quiz {
    public class Solution {
        
        public int MinOperations(string[] logs) {
            int depth = 0;

            foreach (string log in logs) {
                if (log == "../") {
                    depth = Math.Max(0, depth - 1);
                } else if (log == "./") {
                    
                } else {
                    depth++;
                }
            }

            return depth;
        }
        
    }
}