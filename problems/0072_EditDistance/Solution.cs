using System;

namespace Quiz {
    public class Solution {

        public int MinDistance(string word1, string word2) {
            if (word1.Length <= 0 || word2.Length <= 0) {
                return word1.Length + word2.Length;
            }

            var dp = new int[word1.Length + 1, word2.Length + 1];

            for (var i = 0; i <= word1.Length; i++) {
                dp[i, 0] = i;
            }
            for (var j = 0; j <= word2.Length; j++) {
                dp[0, j] = j;
            }

            for (var i = 1; i <= word1.Length; i++) {
                for (var j = 1; j <= word2.Length; j++) {
                    int i_1 = i - 1;
                    int j_1 = j - 1;

                    if (word1[i_1] != word2[j_1]) {
                        dp[i, j] = Math.Min(dp[i_1, j_1], Math.Min(dp[i_1, j], dp[i, j_1])) + 1;
                    } else {
                        dp[i, j] = dp[i_1, j_1];
                    }
                }
            }

            return dp[word1.Length, word2.Length];
        }

    }
}
