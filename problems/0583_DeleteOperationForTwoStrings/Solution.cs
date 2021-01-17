using System;

namespace Quiz {
    public class Solution {
        
        public int MinDistance(string word1, string word2) {
            int[,] dp = new int[word1.Length + 1, word2.Length + 1];

            for (int i = word1.Length - 1; i >= 0; i--) {
                dp[i, word2.Length] = dp[i + 1, word2.Length] + 1;
            }
            for (int j = word2.Length - 1; j >= 0; j--) {
                dp[word1.Length, j] = dp[word1.Length, j + 1] + 1;
            }

            for (int i = word1.Length - 1; i >= 0; i--) {
                for (int j = word2.Length - 1; j >= 0; j--) {
                    if (word1[i] == word2[j]) {
                        dp[i, j] = dp[i + 1, j + 1];
                    } else {
                        dp[i, j] = Math.Min(dp[i + 1, j], dp[i, j + 1]) + 1;
                    }
                }
            }

            return dp[0, 0];        
        }
        
    }
}