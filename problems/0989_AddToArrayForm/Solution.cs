using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public IList<int> AddToArrayForm(int[] A, int K) {
            int ai = A.Length - 1;
            var c = 0;

            var result = new Stack<int>();

            while (ai >= 0 || K > 0 || c > 0) {
                int aa = ai >= 0 ? A[ai--] : 0;

                int bb = K % 10;
                K /= 10;

                c += aa + bb;

                result.Push(c % 10);

                c /= 10;
            }

            return result.ToArray();
        }

    }
}
