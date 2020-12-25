using System.Text;

namespace Quiz {
    public class Solution {

        public bool BackspaceCompare(string S, string T) {
            return Backspace(S) == Backspace(T);
        }
        
        private string Backspace(string S) {
            StringBuilder sb = new StringBuilder();

            foreach (char c in S) {
                if (c == '#') {
                    if (sb.Length > 0) {
                        sb.Remove(sb.Length - 1, 1);
                    }
                } else {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

    }
}