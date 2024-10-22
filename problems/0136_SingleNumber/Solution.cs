namespace Quiz {
    public class Solution {

        public int SingleNumber(int[] nums) {
            var result = 0;

            for (var index = 0; index < nums.Length; index++) {
                result ^= nums[index];
            }

            return result;
        }

    }
}
