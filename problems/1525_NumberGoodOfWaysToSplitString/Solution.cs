using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public int NumSplits(string s) {
            if (s.Length < 2) {
                return 0;
            } else if (s.Length < 3) {
                return 1;
            }
            
            var left_hs = new HashSet<char>();
            var right_hs = new HashSet<char>();

            var left_uniques = new int[s.Length - 1];
            var right_uniques = new int[s.Length - 1];
            for (var i = 0; i < s.Length - 1; i++) {
                char lc = s[i];
                left_hs.Add(lc);
                left_uniques[i] = left_hs.Count;

                char rc = s[^(i + 1)];
                right_hs.Add(rc);
                right_uniques[^(i + 1)] = right_hs.Count;
            }

            var count = 0;
            
            for (var i = 0; i < s.Length - 1; i++) {
                if (left_uniques[i] == right_uniques[i]) {
                    count++;
                }
            }

            return count;
        }
        
    }
}