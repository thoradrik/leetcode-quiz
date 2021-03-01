namespace Quiz {
    public class Solution {
        
        public char[] ReverseString2(char[] s) {
            ReverseString(s);
            return s;
        }

        public void ReverseString(char[] s) {
            for (int x_index = 0; x_index < s.Length / 2; x_index++) {
                ref char x = ref s[x_index];
                
                int y_index = s.Length - x_index - 1;
                
                ref char y = ref s[y_index];
                
                x ^= y;
                y ^= x;
                x ^= y;
            }
        }

    }
}