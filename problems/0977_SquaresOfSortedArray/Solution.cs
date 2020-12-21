namespace Quiz {
    public class Solution {
        
        public int[] SortedSquares(int[] nums) {
            int i_left = 0;
            int i_right = nums.Length - 1;
            int i = i_right;
            int[] result = new int[nums.Length];
            
            while (i_left <= i_right) {
                int s_left = nums[i_left] * nums[i_left];
                int s_right = nums[i_right] * nums[i_right];
                if (s_left < s_right) {
                    result[i] = s_right;
                    i_right--;
                } else {
                    result[i] = s_left;
                    i_left++;
                }

                i--;
            }

            return result;
        }
        
    }
}