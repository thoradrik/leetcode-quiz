namespace Quiz {
    public class Solution {

        public int Reverse(int x) {
            var mult = 1;
            if (x < 0) {
                x = -x;
                mult = -1;
            } else {
                mult = 1;
            }

            var result = 0;

            while (x > 0) {
                if (result > 214748364) {
                    return 0;
                }

                result *= 10;

                result += x % 10;

                x /= 10;
            }

            return result * mult;
        }

    }
}
