namespace Quiz {
    public class Solution {
        
        public bool IsPerfectSquare(int num) {
            if (num <= 1) {
                return true;
            } else {
                long a = 2;
                long b = num / 2;

                do {
                    long v = (a + b) / 2;
                    long v2 = v * v;
                    if (v2 == num) {
                        return true;
                    } else if (v2 < num) {
                        a = v;
                    } else {
                        b = v;
                    }
                } while (b - a > 1);

                return false;
            }
        }
        
    }
}