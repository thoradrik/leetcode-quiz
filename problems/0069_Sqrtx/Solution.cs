namespace Quiz {
    public class Solution {
        
        public int MySqrt(int x) {
            if (x == 0) {
                return 0;
            } else {
                long a = 2;
                long b = x / 2;

                do {
                    long v = (a + b) / 2;
                    long v2 = v * v;
                    if (v2 == x) {
                        return (int) v;
                    } else if (v2 < x) {
                        a = v;
                    } else {
                        b = v;
                    }
                } while (b - a > 1);

                return (int)a;
            }
        }
        
    }
}