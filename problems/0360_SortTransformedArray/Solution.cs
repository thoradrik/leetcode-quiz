namespace Quiz {
    public class Solution {

        public int[] SortTransformedArray(int[] nums, int a, int b, int c) {
            var result = new int[nums.Length];

            int i;

            if (a > 0) {
                i = nums.Length - 1;
            } else {
                i = 0;
            }

            var i_left = 0;
            int i_right = nums.Length - 1;

            while (i_left <= i_right) {
                int left_result = a * nums[i_left] * nums[i_left] + b * nums[i_left] + c;
                int right_result = a * nums[i_right] * nums[i_right] + b * nums[i_right] + c;

                if ((a > 0) ^ (left_result < right_result)) {
                    result[i] = left_result;
                    i_left++;
                } else {
                    result[i] = right_result;
                    i_right--;
                }

                if (a > 0) {
                    i--;
                } else {
                    i++;
                }
            }

            return result;
        }

    }
}
