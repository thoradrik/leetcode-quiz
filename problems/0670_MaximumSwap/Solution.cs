namespace Quiz {
    public class Solution {
        
        public int MaximumSwap(int num) {
            int max = num;

            int[] d = new int[10];
            int d_max = 0;
            
            while (num > 0) {
                d[d_max] = num % 10;
                num /= 10;
                d_max++;
            }

            if (d_max < 2) {
                return max;
            }

            for (int i = 0; i < d_max; i++) {
                for (int j = 0; j < d_max; j++) {
                    if (i != j && d[i] > d[j]) {
                        int r = 0;
                        for (int k = d_max - 1; k >= 0; k--) {
                            r *= 10;
                            if (k == i) {
                                r += d[j];    
                            } else if (k == j) {
                                r += d[i];
                            } else {
                                r += d[k];
                            }
                            
                        }
                        
                        if (r > max) {
                            max = r;
                        }
                    }
                }
            }

            return max;
        }
        
    }
}