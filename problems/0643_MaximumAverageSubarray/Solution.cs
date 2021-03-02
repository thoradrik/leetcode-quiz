using System;

namespace Quiz {
    public class Solution {
        
        public double FindMaxAverage(int[] nums, int k) {
            double candidate = 0.0d;
            
            for (int i = 0; i < k; i++) {
                candidate += nums[i];
            }

            double max = candidate;

            for (int i = k; i < nums.Length; i++) {
                candidate += nums[i] - nums[i - k];
                
                max = Math.Max(max, candidate);
            }

            return max / k;
        }
        
    }
}