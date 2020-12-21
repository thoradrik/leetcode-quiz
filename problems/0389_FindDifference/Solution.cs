namespace Quiz {
    public class Solution {

        public char FindTheDifference(string s, string t) {
            char r = '\0';
            
            for (int i = 0; i < s.Length; i++) {
                r ^= s[i];
            }
            for (int i = 0; i < t.Length; i++) {
                r ^= t[i];
            }

            return r;
        }

    }
}