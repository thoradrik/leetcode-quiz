using System.Text;

namespace Quiz {
    public class Solution {

        public string ShortestPalindrome(string s) {
            int length = s.Length;

            for (; length > 0; length--) {
                var start = 0;
                int end = length - 1;

                while (s[start] == s[end] && start < end) {
                    start++;
                    end--;
                }

                if (start >= end) {
                    break;
                }
            }

            if (length <= 0) {
                return s;
            }

            var sb = new StringBuilder(length + s.Length);

            for (int i = s.Length - 1; i >= length; i--) {
                sb.Append(s[i]);
            }

            sb.Append(s);

            return sb.ToString();
        }

    }
}
