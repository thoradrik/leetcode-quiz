namespace Quiz {
    public class Solution {
        
        public void Merge(int[] nums1, int m, int[] nums2, int n) {
            int i_1 = m - 1;
            int i_2 = n - 1;
            int i = m + n - 1;
            
            while (i_1 >= 0 || i_2 >= 0) {
                bool z;
                
                if (i_1 >= 0 && i_2 >= 0) {
                    int n_1 = nums1[i_1];
                    int n_2 = nums2[i_2];

                    z = n_1 > n_2;
                } else {
                    z = i_1 >= 0;
                } 
                
                if (z) {
                    nums1[i] = nums1[i_1];
                    i_1--;
                } else {
                    nums1[i] = nums2[i_2];
                    i_2--;
                }

                i--;
            }
        }
        
    }
}