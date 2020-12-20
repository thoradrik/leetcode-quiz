using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public int[] PlusOne(int[] digits) {
            int i = digits.Length - 1;

            if (i >= 0) {
                digits[i]++;
            }

            Stack<int> result = new Stack<int>(digits.Length);
            
            int k = 0;

            while (i >= 0) {
                k += digits[i];
                result.Push(k % 10);
                k /= 10;
                i--;
            }

            if (k > 0) {
                result.Push(k);
            }
            
            return result.ToArray();
        }

    }
}