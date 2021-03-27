namespace Quiz {
    public class Solution {
        
        public bool IsMajorityElement(int[] nums, int target) {
            if (nums.Length < 2) {
                return nums[0] == target;
            }
            
            int search_start(int i, int j) {
                if (nums[i] == target) return i;

                while (j - i > 1) {
                    int m = (i + j) / 2;
                    if (nums[m] >= target) {
                        j = m;
                    } else {
                        i = m;
                    }
                }

                return j;
            }

            int search_end(int i, int j) {
                if (nums[j] == target) return j;
                
                while (j - i > 1) {
                    int m = (i + j) / 2;
                    if (nums[m] <= target) {
                        i = m;
                    } else {
                        j = m;
                    }
                }

                return i;
            }

            int start = search_start(0, nums.Length - 1);
            int end = search_end(0, nums.Length - 1);
            int length = end - start + 1;
            
            return length > nums.Length / 2;
        }
        
    }
}