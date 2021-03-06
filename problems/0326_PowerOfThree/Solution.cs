namespace Quiz {
    public class Solution {
        
        public bool IsPowerOfThree(int n) {
            if (n > 0) {
                return 1162261467 % n == 0;
            } else {
                return false;
            }
        }
        
    }
}