using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public int[] NextGreaterElement(int[] nums1, int[] nums2) {
            Dictionary<int, int> map = new Dictionary<int, int>();
            
            Stack<int> stack = new Stack<int>();
            
            for (int i = nums2.Length - 1; i >= 0; i--) {
                int n_i = nums2[i];

                while (stack.TryPeek(out int top) && top <= n_i) {
                    stack.Pop();
                }

                map[n_i] = stack.TryPeek(out int n) ? n : -1;
                
                stack.Push(n_i);
            }

            return Array.ConvertAll(nums1, n1 => map.TryGetValue(n1, out int n2) ? n2 : -1);
        }
        
    }
}