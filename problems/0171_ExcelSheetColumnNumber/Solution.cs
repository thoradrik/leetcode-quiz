namespace Quiz {
    public class Solution {

        public int TitleToNumber(string s) {
            var result = 0;

            for (var i = 0; i < s.Length; i++) {
                int n = s[i] - 'A';
                result *= 26;
                result += n + 1;
            }

            return result;
        }

    }
}
