using System.Text;

namespace Quiz {
    public class Solution {

        public string RemoveOuterParentheses(string S) {
            var sb = new StringBuilder();

            var depth = 0;
            foreach (char c in S) {
                if (c == '(') {
                    if (depth > 0) {
                        sb.Append(c);
                    }
                    depth++;
                } else {
                    depth--;
                    if (depth > 0) {
                        sb.Append(c);
                    }
                }
            }

            return sb.ToString();
        }

    }
}
