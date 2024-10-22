namespace Quiz;

public class Solution {

    public long ZeroFilledSubarray(int[] nums) {
        var lengths = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                if (i > 0) {
                    lengths[i] = lengths[i - 1] + 1;
                    lengths[i - 1] = 0;
                } else {
                    lengths[i] = 1;
                }
            } else {
                lengths[i] = 0;
            }
        }

        long result = 0;

        for (var i = 0; i < lengths.Length; i++) {
            long length = lengths[i];
            if (length > 0) {
                result += length * (length + 1) / 2;
            }
        }

        return result;
    }

}
