using System;

namespace Quiz {
    public class Solution {

        public int FindDuplicate(int[] nums) {
            Array.Sort(nums);

            int a = nums[0];
            var i = 1;

            while (i < nums.Length) {
                int b = nums[i];
                if (a == b) {
                    return a;
                }

                a = b;

                i++;
            }

            return -1;
        }

    }
}
