using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public int[] NextGreaterElements(int[] nums) {
            int[] nge = new int[nums.Length];
            
            Stack<int> stack = new Stack<int>();
            
            for (int j = 2 * nums.Length - 1; j >= 0; j--) {
                int i = j % nums.Length;

                while (stack.TryPeek(out int i_top) && nums[i_top] <= nums[i]) {
                    stack.Pop();
                }

                if (stack.TryPeek(out int i_nge)) {
                    nge[i] = nums[i_nge];
                } else {
                    nge[i] = -1;
                }

                stack.Push(i);
            }

            return nge;
        }
        
    }
}