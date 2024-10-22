namespace Quiz {
    public class Solution {

        public int NthSuperUglyNumber(int n, int[] primes) {
            var nums = new int[n];
            nums[0] = 1;

            var ptr = new int[primes.Length];
            var muls = new int[primes.Length];
            for (var p = 0; p < primes.Length; p++) {
                muls[p] = nums[ptr[p]] * primes[p];
            }

            for (var i = 1; i < n; i++) {
                int min = muls[0];

                for (var p = 1; p < primes.Length; p++) {
                    if (muls[p] < min) {
                        min = muls[p];
                    }
                }

                nums[i] = min;

                for (var p = 0; p < primes.Length; p++) {
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
