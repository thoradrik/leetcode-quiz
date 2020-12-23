using System.Text;

namespace Quiz {
    public class Solution {

        public string RemoveOuterParentheses(string S) {
            StringBuilder sb = new StringBuilder();

            int depth = 0;
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