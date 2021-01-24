namespace Quiz {
    public class Solution {
        
        public TreeNode SortedArrayToBST(int[] nums) {
            TreeNode backtrack(int start, int end) {
                if (start > end) {
                    return null;
                } else if (start == end) {
                    return new TreeNode(nums[start]);
                } else {
                    int m = (start + end) / 2;
                    return new TreeNode(nums[m]) {
                        left = backtrack(start, m - 1),
                        right = backtrack(m + 1, end)
                    };
                }
            }
            
            return backtrack(0, nums.Length - 1);
        }

    }
}