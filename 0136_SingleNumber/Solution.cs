namespace Quiz {
    public class Solution {
        
        public int SingleNumber(int[] nums) {
            int result = 0;

            for (int index = 0; index < nums.Length; index++) {
                result ^= nums[index];
            }

            return result;
        }
        
    }
}