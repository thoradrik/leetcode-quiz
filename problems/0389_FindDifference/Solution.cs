namespace Quiz {
    public class Solution {

        public char FindTheDifference(string s, string t) {
            var r = '\0';

            for (var i = 0; i < s.Length; i++) {
                r ^= s[i];
            }
            for (var i = 0; i < t.Length; i++) {
                r ^= t[i];
            }

            return r;
        }

    }
}
