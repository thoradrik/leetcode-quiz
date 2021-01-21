namespace Quiz {
    public class Solution {
        
        public int NthSuperUglyNumber(int n, int[] primes) {
            int[] nums = new int[n];
            nums[0] = 1;

            int[] ptr = new int[primes.Length];
            int[] muls = new int[primes.Length];
            for (int p = 0; p < primes.Length; p++) {
                muls[p] = nums[ptr[p]] * primes[p];
            }
            
            for (int i = 1; i < n; i++) {
                int min = muls[0];
                
                for (int p = 1; p < primes.Length; p++) {
                    if (muls[p] < min) {
                        min = muls[p];
                    }
                }

                nums[i] = min;

                for (int p = 0; p < primes.Length; p++) {
                    if (muls[p] == min) {
                        ptr[p]++;
                        muls[p] = nums[ptr[p]] * primes[p];
                    }
                }
            }

            return nums[n - 1];
        }
        
    }
}