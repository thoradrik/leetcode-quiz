using System;

namespace Quiz {
    public class Solution {

        public int TwoSumLessThanK(int[] nums, int k) {
            Array.Sort(nums);

            int max = -1;

            var j_lo = 0;
            int j_hi = nums.Length - 1;
            do {
                int sum = nums[j_lo] + nums[j_hi];

                if (sum >= k) {
                    j_hi--;
                } else {
                    max = Math.Max(max, sum);

                    j_lo++;
                }
            } while (j_lo < j_hi);

            return max;
        }

    }
}
