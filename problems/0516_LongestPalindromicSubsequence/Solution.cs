using System;

namespace Quiz {
    public class Solution {
        
        public int LongestPalindromeSubseq(string s) {
            int max = 0;
            
            void promote(int start, int end) {
                while (s[start] == s[end] && start > 0 && end < s.Length - 1) {
                    start--;
                    end++;
                }

                if (s[start] != s[end]) {
                    start++;
                    end--;
                }

                max = Math.Max(max, end - start + 1);
            }
            
            for (int i = 0; i < s.Length; i++) {
                if (i > 0) {
                    if (s[i - 1] == s[i]) {
                        promote(i - 1, i);
                    }
                }
                
                promote(i, i);
            }

            return max;
        } 

    }
}