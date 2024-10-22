using System;

namespace Quiz {
    public class Solution {

        /*
        public int CountPrimes(int n) {
            if (n <= 2) {
                return 0;
            } else if (n <= 3) {
                return 1;
            } else {
                int n_sq = (int)Math.Sqrt(n);

                List<int> primes = new List<int>(n_sq);

                primes.Add(2);

                int i = 3;
                while (i < n) {
                    for (int index = 0; index < primes.Count; index++) {
                        int prime = primes[index];
                        if (prime > n_sq) {
                            break;
                        }
                        if (i % prime == 0) {
                            goto next_i;
                        }
                    }

                    primes.Add(i);

                next_i:
                    i += 2;
                }

                return primes.Count;
            }
        }
        */

        public int CountPrimes(int n) {
            if (n <= 2) {
                return 0;
            } else if (n <= 3) {
                return 1;
            } else {
                var n_sq = (int)Math.Sqrt(n);

                var nums = new bool[n];

                nums[0] = true;
                nums[1] = true;

                var primes = 0;

                for (var i = 1; i < n; i += 2) {
                    if (nums[i]) {
                        continue;
                    }

                    primes++;

                    if (i <= n_sq) {
                        for (int j = i * i; j < nums.Length; j += i) {
                            nums[j] = true;
                        }
                    }
                }

                return primes + 1;
            }
        }

    }
}
