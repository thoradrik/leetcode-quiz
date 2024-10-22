using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public int NextGreaterElement(int n) {
            int[] digits = GetDigits(n);

            if (TryMakeNextGreaterElement(digits)) {
                return GetNumber(digits);
            } else {
                return -1;
            }
        }

        public bool TryMakeNextGreaterElement(int[] digits) {
            for (int i = digits.Length - 2; i >= 0; i--) {
                int d_i = digits[i];

                var min = 10;
                int min_j = -1;

                for (int j = i + 1; j < digits.Length; j++) {
                    int d_j = digits[j];

                    if (d_i < d_j) {
                        if (d_j < min) {
                            min = d_j;
                            min_j = j;
                        }
                    }
                }

                if (min_j > 0) {
                    int tmp = digits[i];
                    digits[i] = digits[min_j];
                    digits[min_j] = tmp;

                    MinimizeElement(digits, i + 1);

                    return true;
                }
            }

            return false;
        }

        private void MinimizeElement(int[] digits, int end) {
            Array.Sort(digits, end, digits.Length - end);
        }

        private static int[] GetDigits(int n) {
            var list = new List<int>();

            while (n > 0) {
                list.Insert(0, n % 10);
                n /= 10;
            }

            return list.ToArray();
        }

        private static int GetNumber(int[] digits) {
            long result = 0;

            for (var i = 0; i < digits.Length; i++) {
                result = result * 10 + digits[i];
            }

            return result > Int32.MaxValue ? -1 : (int)result;
        }

    }

}
