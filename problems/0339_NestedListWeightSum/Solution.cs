using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public int DepthSum(IList<NestedInteger> nestedList) => DepthSum(nestedList, 1); 
            
        public int DepthSum(IList<NestedInteger> nestedList, int depth) {
            int sum = 0;
            
            for (int i = 0; i < nestedList.Count; i++) {
                NestedInteger item = nestedList[i];
                if (item.IsInteger()) {
                    sum += depth * item.GetInteger();
                } else {
                    sum += DepthSum(item.GetList(), depth + 1);
                }
            }

            return sum;
        }

    }
}