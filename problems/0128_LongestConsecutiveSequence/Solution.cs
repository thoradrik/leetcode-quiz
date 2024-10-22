namespace Quiz;

public class Solution {
    public int LongestConsecutive_TrueOn_ButSlower(int[] nums) {
        var set = new HashSet<int>(nums);

        var max = 0;

        for (var i = 0; i < nums.Length; i++) {
            var prev_value = nums[i] - 1;
            if (!set.Contains(prev_value)) {
                var value = nums[i];
                var length = 1;

                while (set.Contains(value + length)) {
                    length++;
                }

                max = Math.Max(max, length);
            }
        }

        return max;
    }

    public int LongestConsecutive(int[] nums) {
        Array.Sort(nums);

        var length = new int[nums.Length];

        var max = 0;

        for (var i = 0; i < nums.Length; i++) {
            if (i > 0) {
                var diff = nums[i] - nums[i - 1];
                if (diff <= 1) {
                    length[i] = length[i - 1] + diff;
                } else {
                    length[i] = 1;
                }
            } else {
                length[i] = 1;
            }

            max = Math.Max(max, length[i]);
        }

        return max;
    }
}
