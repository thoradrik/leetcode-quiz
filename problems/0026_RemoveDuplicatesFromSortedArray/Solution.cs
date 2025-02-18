namespace Quiz;

public class Solution {

    public int RemoveDuplicates(int[] nums) {
        var c_i = 0;
        var c_num = nums[c_i];

        for (var i = 1; i < nums.Length; i++) {
            var num = nums[i];
            if (num != c_num) {
                c_i++;
                nums[c_i] = num;
                c_num = num;
            }
        }

        return c_i + 1;
    }

}
