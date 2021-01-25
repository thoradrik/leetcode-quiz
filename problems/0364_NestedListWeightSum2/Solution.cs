using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public int DepthSumInverse(IList<NestedInteger> nestedList) {
            List<int> sums = new List<int>();
            
            void backtrack(IList<NestedInteger> list, int depth) {
                if (sums.Count <= depth) {
                    sums.Add(0);
                }
            
                for (int i = 0; i < list.Count; i++) {
                    NestedInteger item = list[i];
                    if (item.IsInteger()) {
                        sums[depth] += item.GetInteger();
                    } else {
                        backtrack(item.GetList(), depth + 1);
                    }
                }
            }

            backtrack(nestedList, 0);
            
            int sum = 0;
            
            for (int i = 0; i < sums.Count; i++) {
                sum += sums[i] * (sums.Count - i);
            }
            
            return sum;
        }
        
    }
}