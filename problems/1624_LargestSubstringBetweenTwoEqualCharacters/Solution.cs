using System;

namespace Quiz {
    public class Solution {
        
        public int MaxLengthBetweenEqualCharacters(string s) {
            int[] min = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            int[] max = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            
            int max_lenght = -1;
            
            for (int i = 0; i < s.Length; i++) {
                int c = s[i] - 'a';
                
                min[c] = min[c] >= 0 ? Math.Min(min[c], i) : i;
                max[c] = max[c] >= 0 ? Math.Max(max[c], i) : i;
                
                if (max[c] != min[c]) {
                    max_lenght = Math.Max(max_lenght, max[c] - min[c] - 1);
                }
            }
            
            return max_lenght;
        }
        
    }
}