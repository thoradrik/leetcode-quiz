using System.Collections.Generic;
using System.Text;

namespace Quiz {
    public class Solution {
        
        public IList<IList<int>> PermuteUnique(int[] nums) {
            Dictionary<string, IList<int>> map = new Dictionary<string, IList<int>>();

            void add() {
                StringBuilder sb = new StringBuilder();
                
                for (int i = 0; i < nums.Length; i++) {
                    sb.Append(",");
                    sb.Append(nums[i]);
                }

                map[sb.ToString()] = new List<int>(nums);
            }
            
            void swap<T>(ref T a, ref T b) {
                T tmp = a;
                a = b;
                b = tmp;
            }
            
            int[] stack = new int[nums.Length];
            int ptr = 0;

            add();

            while (ptr < nums.Length) {
                if (stack[ptr] < ptr) {
                    if (ptr % 2 == 0) {
                        swap(ref nums[0], ref nums[ptr]);
                    } else {
                        swap(ref nums[stack[ptr]], ref nums[ptr]);
                    }

                    add();

                    stack[ptr]++;
                    ptr = 0;
                } else {
                    stack[ptr] = 0;
                    ptr++;
                }
            }
            
            return new List<IList<int>>(map.Values);
        }

    }
}