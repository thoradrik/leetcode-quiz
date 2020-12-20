using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        /*
         
        public int[] TwoSum(int[] nums, int target) {
            for (int i = 0; i < nums.Length; i++) {
                for (int j = 0; j < nums.Length; j++) {
                    if (i != j && nums[i] + nums[j] == target) {
                        return new[] { i, j };
                    }
                }
            }

            return Array.Empty<int>();
        }
        
        */
        
        public int[] TwoSum(int[] nums, int target) {
            Dictionary<int, int> map = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++) {
                int num = nums[i];
                if (map.TryGetValue(num, out int j)) {
                    return new[] { j, i };
                } else {
                    map[target - num] = i;
                }
            }

            return Array.Empty<int>();
        }

    }
}