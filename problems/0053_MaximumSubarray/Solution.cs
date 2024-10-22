using System;

namespace Quiz {
    public class Solution {

        public int MaxSubArray(int[] nums) {
            var dp = new int[nums.Length];

            int max = nums[0];

            dp[0] = nums[0];

            for (var i = 1; i < nums.Length; i++) {
                dp[i] = dp[i - 1] > 0 ? nums[i] + dp[i - 1] : nums[i];

                max = Math.Max(max, dp[i]);
            }

            return max;
        }

    }
}
