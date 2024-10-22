namespace Quiz {
    public class Solution {

        public bool IsPalindrome(string s) {
            var start = 0;
            int end = s.Length - 1;

            s = s.ToLower();

            bool is_letter_or_digit(char c) => (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');

            while (start < end) {
                char c_start = s[start];
                if (!is_letter_or_digit(c_start)) {
                    start++;
                    continue;
                }

                char c_end = s[end];
                if (!is_letter_or_digit(c_end)) {
                    end--;
                    continue;
                }

                if (c_start != c_end) {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }

    }
}
