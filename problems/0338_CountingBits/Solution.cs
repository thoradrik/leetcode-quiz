namespace Quiz {
    public class Solution {

        public int[] CountBits(int num) {
            var counts = new int[num + 1];

            counts[0] = 0;

            for (var i = 1; i <= num; i++) {
                counts[i] = counts[i >> 1] + (i & 0b1);
            }

            return counts;
        }

    }
}
