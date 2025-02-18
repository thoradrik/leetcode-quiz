namespace Quiz;

public class Solution {

    public int PartitionDisjoint(int[] nums) {
        var split_i = 0;
        var split_max = nums[split_i];

    try_next:
        do {
            split_i++;
        } while (split_i < nums.Length - 1 && nums[split_i] < split_max);

        var new_max = split_max;

        for (var i = split_i; i < nums.Length; i++) {
            var num_i = nums[i];

            if (num_i < split_max) {
                split_i = i;
                split_max = new_max;
                goto try_next;
            }

            if (num_i > new_max) {
                new_max = num_i;
            }
        }

        return split_i;
    }

}
