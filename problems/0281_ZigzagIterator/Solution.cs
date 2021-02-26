using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public int[] Method(int[] v1, int[] v2) {
            List<int> list = new List<int>();
            
            ZigzagIterator i = new ZigzagIterator(v1, v2);
            while (i.HasNext()) {
                list.Add(i.Next());
            }

            return list.ToArray();
        }

    }
}