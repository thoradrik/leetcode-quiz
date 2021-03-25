namespace Quiz {
    public class Solution {
        
        public bool HasAlternatingBits(int n) {
            int prev = n & 2;
            n >>= 1;

            while (n > 0) {
                int current = n & 2;
                if (current == prev) {
                    return false;
                }
                
                n >>= 1;
                prev = current;
            }

            return true;
        }
        
    }
}