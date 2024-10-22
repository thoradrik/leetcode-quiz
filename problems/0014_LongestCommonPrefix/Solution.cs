namespace Quiz {
    public class Solution {

        public string LongestCommonPrefix(string[] strs) {
            if (strs.Length == 1) {
                return strs[0];
            }

            var lcp = 0;

            string s0 = strs[0];

            while (s0.Length > lcp) {
                char p = s0[lcp];

                for (var index = 1; index < strs.Length; index++) {
                    string str = strs[index];
                    if (str.Length <= lcp) {
                        return str;
                    }
                    if (str[lcp] != p) {
                        return s0.Substring(0, lcp);
                    }
                }

                lcp++;
            }

            return s0;
        }

    }
}
