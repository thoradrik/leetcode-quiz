using System;

namespace Quiz {
    public class Solution {

        public int LongestPalindromeSubseq(string s) {
            int[,] dp = new int[s.Length, s.Length];
            
            int max = 0;
            
            for (int start = s.Length - 1; start >= 0; start--) {
                for (int end = start; end < s.Length; end++) {
                    int length = end - start + 1;
                    if (length == 1) {
                        dp[start, end] = 1;
                    } else if (length == 2) {
                        dp[start, end] = s[start] == s[end] ? 2 : 1;
                    } else if (s[start] == s[end]) {
                        dp[start, end] = dp[start + 1, end - 1] + 2;
                    } else {
                        dp[start, end] = Math.Max(dp[start + 1, end], dp[start, end - 1]);
                    }

                    max = Math.Max(max, dp[start, end]);
                }
            }

            return max;
        }

    }
}