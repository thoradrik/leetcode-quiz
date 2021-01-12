using System;

namespace Quiz {
    public class Solution {
        
        public string LastSubstring(string s) {
            int max_start = 0;
            int max_length = s.Length;
            
            for (int start = 1; start < s.Length; start++) {
                int step = 0;
                
                for (int i = 0; i < Math.Min(s.Length - start, max_length); i++) {
                    char c_s = s[start + i];
                    char c_m = s[max_start + i];
                    if (c_s < c_m) {
                        break;
                    } else if (c_s > c_m) {
                        max_start = start;
                        max_length = s.Length - max_start;
                        step = Math.Max(step - 1, 0);
                        break;
                    } else {
                        step++;
                    }
                }

                start += Math.Max(step - 1, 0);
            }

            return s.Substring(max_start, max_length);
        }
        
    }
}