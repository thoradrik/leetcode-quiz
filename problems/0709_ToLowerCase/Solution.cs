using System.Text;

namespace Quiz {
    public class Solution {

        public string ToLowerCase(string str) {
            var sb = new StringBuilder(str.Length);

            foreach (char c in str) {
                if (c >= 'A' && c <= 'Z') {
                    sb.Append((char) (c + 32));
                } else {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

    }
}
