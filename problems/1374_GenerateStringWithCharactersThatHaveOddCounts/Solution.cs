using System.Text;

namespace Quiz {
    public class Solution {

        private static readonly char[] CHARS = { 'a', 'b' };
        
        public string GenerateTheString(int n) {
            var sb = new StringBuilder(n);

            var c_index = 0;
            while (n > 0) {
                int c_count = n;

                while (c_count % 2 == 0) {
                    c_count--;
                }

                sb.Append(CHARS[c_index], c_count);

                n -= c_count;
                c_index++;
            }

            return sb.ToString();
        }
        
    }
}