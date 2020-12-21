namespace Quiz {
    public class Solution {

        public int SuperPow(int a, int[] b) {
            return (int)PowRec(a, b, 1337);    
        }
        
        private long PowRec(long x, int[] n, long k) {
            long a = 1;
            long b = x;
            
            while (IsGreater0(n)) {
                if (n[^1] % 2 == 1) {
                    a = (a * b) % k;
                }

                b = (b * b) % k;
                
                Div2(n);
            }

            return a % k;
        }

        private bool IsGreater0(int[] n) {
            for (int i = n.Length - 1; i >= 0; i--) {
                if (n[i] > 0) {
                    return true;
                }
            }

            return false;
        }

        private void Div2(int[] n) {
            int i = 0;

            while (i < n.Length && n[i] == 0) {
                i++;
            }

            int rem = 0;
            
            while (i < n.Length) {
                int k = n[i] + 10 * rem;
                rem = k % 2;
                n[i] = k / 2;
                i++;
            }
        }

    }
}