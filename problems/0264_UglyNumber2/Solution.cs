using System;

namespace Quiz {
    public class Solution {

        private static int[] NUMS = new int[1690];
        
        static Solution() {
            NUMS[0] = 1;
            
            int ptr_2 = 0;
            int ptr_3 = 0;
            int ptr_5 = 0;

            int n_2 = NUMS[ptr_2] * 2;
            int n_3 = NUMS[ptr_3] * 3;
            int n_5 = NUMS[ptr_5] * 5;

            for (int i = 1; i < NUMS.Length; i++) {
                int min = Math.Min(n_2, Math.Min(n_3, n_5));
                
                NUMS[i] = min;
                
                if (min == n_2) {
                    ptr_2++;
                    n_2 = NUMS[ptr_2] * 2;
                } 
                
                if (min == n_3) {
                    ptr_3++;
                    n_3 = NUMS[ptr_3] * 3;
                } 
                
                if (min == n_5) {
                    ptr_5++;
                    n_5 = NUMS[ptr_5] * 5;
                }
            }
            
        }

        public int NthUglyNumber(int n) {
            return NUMS[n - 1];
        }
        
    }
}