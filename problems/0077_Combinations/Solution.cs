using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public IList<IList<int>> Combine(int n, int k) {
            IList<IList<int>> list = new List<IList<int>>();

            Stack<int> stack = new Stack<int>();

            void backtrack(int kk, int start) {
                if (kk == 0) {
                    if (stack.Count > 0) {
                        list.Add(stack.ToArray());
                    }
                } else {
                    for (int i = start; i <= n; i++) {
                        stack.Push(i);
                        backtrack(kk - 1, i + 1);
                        stack.Pop();
                    }
                }
            }

            backtrack(k, 1);
            
            return list;
        }
        
    }
}