namespace Quiz {
    public class Solution {
        
        public string MakeGood(string s) {
            char[] stack = new char[s.Length];
            int ptr = 0;

            for (int i = 0; i < s.Length; i++) {
                char c = s[i];
                if (ptr > 0) {
                    char prev = stack[ptr - 1];
                    if (prev - c == 32 || c - prev == 32) {
                        ptr--;
                    } else {
                        stack[ptr++] = c;
                    }
                } else {
                    stack[ptr++] = c;
                }
            }
            
            return new string(stack, 0, ptr);
        }
        
    }
}