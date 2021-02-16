using System;

namespace Quiz {
    public class Solution {
        
        public int LargestAltitude(int[] gain) {
            int max = Math.Max(0, gain[0]);

            for (int i = 1; i < gain.Length; i++) {
                gain[i] += gain[i - 1];
            
                max = Math.Max(max, gain[i]);
            }

            return max;
        }
        
    }
}