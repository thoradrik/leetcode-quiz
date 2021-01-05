using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public IList<IList<int>> Permute(int[] nums) {
            IList<IList<int>> list = new List<IList<int>>();
            
            int[] stack = new int[nums.Length];
            int ptr = 0;

            list.Add(new List<int>(nums));

            while (ptr < nums.Length) {
                if (stack[ptr] < ptr) {
                    if (ptr % 2 == 0) {
                        Swap(ref nums[0], ref nums[ptr]);
                    } else {
                        Swap(ref nums[stack[ptr]], ref nums[ptr]);
                    }

                    list.Add(new List<int>(nums));

                    stack[ptr]++;
                    ptr = 0;
                } else {
                    stack[ptr] = 0;
                    ptr++;
                }
            }
            
            return list;
        }

        private static void Swap<T>(ref T a, ref T b) {
            T tmp = a;
            a = b;
            b = tmp;
        }
        
    }
}