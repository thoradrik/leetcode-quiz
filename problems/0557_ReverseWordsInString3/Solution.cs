namespace Quiz {
    public class Solution {

        public string ReverseWords(string s) {
            char[] chars = s.ToCharArray();

            void swap(int start, int end) {
                for (; start < end; start++, end--) {
                    ref char x = ref chars[start];
                    ref char y = ref chars[end];
                    x ^= y;
                    y ^= x;
                    x ^= y;
                }
            }

            var w_start = 0;

            for (var i = 1; i < s.Length; i++) {
                if (chars[i] == ' ') {
                    int w_end = i - 1;

                    swap(w_start, w_end);

                    w_start = i + 1;
                }
            }

            swap(w_start, s.Length - 1);

            return new string(chars);
        }

    }
}
