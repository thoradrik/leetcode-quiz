using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public int[] DiStringMatch(string S) {
            var low = 0;
            int high = S.Length;

            var list = new List<int>(S.Length + 1);

            foreach (char c in S) {
                if (c == 'I') {
                    list.Add(low++);
                } else {
                    list.Add(high--);
                }
            }

            list.Add(low);

            return list.ToArray();
        }

    }
}
