namespace Quiz {
    public class Solution {

        public int FixedPoint(int[] arr) {
            var i_lo = 0;
            int i_hi = arr.Length - 1;

            int i_min = -1;

            do {
                int i = (i_lo + i_hi) / 2;
                int ai = arr[i];
                if (ai >= i) {
                    if (ai == i) {
                        i_min = i;
                    }

                    i_hi = i - 1;
                } else {
                    i_lo = i + 1;
                }
            } while (i_lo <= i_hi);

            return i_min;
        }

    }
}
