namespace Quiz {
    public class Solution {

        public string ShiftingLetters(string str, int[] shifts) {
            int len = str.Length;

            var sum = new long[len];

            sum[len - 1] = shifts[len - 1];

            for (int i = len - 2; i >= 0; i--) {
                sum[i] = sum[i + 1] +  shifts[i];
            }

            var sb = new char[len];

            for (var i = 0; i < len; i++) {
                sb[i] = (char)((str[i] + sum[i] - 'a') % 26 + 'a');
            }

            return new string(sb);
        }

    }
}
