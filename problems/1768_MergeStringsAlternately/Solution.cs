using System;
using System.Text;

namespace Quiz {
    public class Solution {
        
        public string MergeAlternately(string word1, string word2) {
            StringBuilder sb = new StringBuilder(word1.Length + word2.Length);

            int min_length = Math.Min(word1.Length, word2.Length);
            
            for (int i = 0; i < min_length; i++) {
                sb.Append(word1[i]);
                sb.Append(word2[i]);
            }

            if (word1.Length > min_length) {
                sb.Append(word1.Substring(min_length));
            }
            if (word2.Length > min_length) {
                sb.Append(word2.Substring(min_length));
            }

            return sb.ToString();
        }
        
    }
}