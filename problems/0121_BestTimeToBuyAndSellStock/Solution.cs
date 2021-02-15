using System;

namespace Quiz {
    public class Solution {
        
        public int MaxProfit(int[] prices) {
            int[] max = new int[prices.Length];
            
            max[^1] = prices[^1];
            
            for (int i = prices.Length - 2; i >= 0; i--) {
                max[i] = Math.Max(prices[i], max[i + 1]);
            }

            int[] min = new int[prices.Length];
            
            min[0] = prices[0];
            
            for (int i = 1; i < prices.Length; i++) {
                min[i] = Math.Min(prices[i], min[i - 1]);
            }

            int best = 0;
            
            for (int i = 0; i < max.Length; i++) {
                best = Math.Max(best, max[i] - min[i]);
            }

            return Math.Max(best, 0);
        }
        
    }
}