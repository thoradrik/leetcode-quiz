using System;

namespace Quiz {
    public class Solution {

        public int MaxProfit(int[] prices) {
            var max = new int[prices.Length];

            max[^1] = prices[^1];

            for (int i = prices.Length - 2; i >= 0; i--) {
                max[i] = Math.Max(prices[i], max[i + 1]);
            }

            var min = new int[prices.Length];

            min[0] = prices[0];

            for (var i = 1; i < prices.Length; i++) {
                min[i] = Math.Min(prices[i], min[i - 1]);
            }

            var best = 0;

            for (var i = 0; i < max.Length; i++) {
                best = Math.Max(best, max[i] - min[i]);
            }

            return Math.Max(best, 0);
        }

    }
}
