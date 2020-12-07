namespace Quiz {
    public class Solution {
        
        public int MySqrt(int x) {
            if (x == 0) {
                return 0;
            } else if (x < 4) {
                return 1;
            } else {
                long a = 2;
                long b = x / 2;
                
                while (b - a > 1) {
                    long v = (a  + b) / 2;
                    long v2 = v * v;
                    if (v2 == x) {
                        return (int)v;
                    } else if (v2 < x) {
                        a = v;
                    } else {
                        b = v;
                    }
                }

                return (int)a;
            }
        }
        
    }
}