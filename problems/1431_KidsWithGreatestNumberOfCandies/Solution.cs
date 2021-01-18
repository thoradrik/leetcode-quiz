using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
            int max = 0;

            for (int i = 0; i < candies.Length; i++) {
                max = Math.Max(max, candies[i]);
            }

            return Array.ConvertAll(candies, c => c + extraCandies >= max);
        }
        
    }
}