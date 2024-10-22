namespace Quiz {
    public class Solution {

        private static readonly char[] DIGITS = { '-', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public string ConvertToTitle(int n) {
            var right = 10;
            int left = right;
            var chars = new char[right + 1];

        next:
            if (n < 27) {
                chars[--left] = DIGITS[n];
            } else {
                n -= 1;

                chars[--left] = DIGITS[n % 26 + 1];

                n /= 26;

                goto next;
            }

            return new string(chars[left..right]);
        }

    }
}
