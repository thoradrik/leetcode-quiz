using System;

namespace Quiz {
    public class Solution {
        
        public int WaysToMakeFair(int[] nums) {
            if (nums.Length < 3) {
                return 1;
            }

            int[] s_sum = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++) {
                if (i < 2) {
                    s_sum[i] = nums[i];
                } else {
                    s_sum[i] = nums[i] + s_sum[i - 2];
                }
            }

            int[] e_sum = new int[nums.Length];

            for (int i = nums.Length - 1; i >= 0; i--) {
                if (i > nums.Length - 3) {
                    e_sum[i] = nums[i];
                } else {
                    e_sum[i] = nums[i] + e_sum[i + 2];
                }
            }
            
            int count = 0;

            for (int i = 0; i < nums.Length; i++) {
                int odd_sum = 0;
                int even_sum = 0;
                if (i % 2 == 0) {
                    // E O E [O] O E O E
                    even_sum += i >= 1 ? s_sum[i - 1] : 0;
                    odd_sum += i >= 2 ? s_sum[i - 2] : 0;
                    even_sum += i < nums.Length - 2 ? e_sum[i + 2] : 0;
                    odd_sum += i < nums.Length - 1 ? e_sum[i + 1] : 0;
                } else {
                    // E O [E] E O E O E
                    even_sum += i >= 2 ? s_sum[i - 2] : 0;
                    odd_sum += i >= 1 ? s_sum[i - 1] : 0;
                    even_sum += i < nums.Length - 1 ? e_sum[i + 1] : 0;
                    odd_sum += i < nums.Length - 2 ? e_sum[i + 2] : 0;
                }

                if (odd_sum == even_sum) {
                    
                    /*
                    Console.Write("[");
                    for (int j = 0; j < nums.Length; j++) {
                        if (i != j) {
                            Console.Write(" {0} ", nums[j]);
                        }
                    }
                    Console.WriteLine("]");
                    */
                    
                    count++;
                }
            }
            
            return count;
        }
        
    }
}