namespace Quiz;

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        var set = new HashSet<(int, int, int)>();

        for (var i = 0; i < nums.Length; i++) {
            var num_i = nums[i];
            if (num_i > 0) {
                break;
            }

            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }

            for (var j = i + 1; j < nums.Length; j++) {
                var num_j = nums[j];
                var sum = -(num_i + num_j);

                var k = FindIndex(nums, sum, j + 1);
                if (k > 0) {
                    var num_k = nums[k];
                    set.Add((num_i, num_j, num_k));
                }
            }
        }

        var results = new List<IList<int>>();

        foreach (var (num_i, num_j, num_k) in set) {
            results.Add(new List<int> { num_i, num_j, num_k });
        }

        return results;
    }

    public int FindIndex(int[] nums, int value, int lo) {
        var hi = nums.Length - 1;

        while (lo < hi) {
            var mid_i = (lo +  hi) / 2;
            var mid = nums[mid_i];
            if (value == mid) {
                return mid_i;
            }

            if (value < mid) {
                hi = mid_i - 1;
            } else {
                lo = mid_i + 1;
            }
        }

        if (lo == hi && nums[lo] == value) {
            return lo;
        }

        return -1;
    }
}
