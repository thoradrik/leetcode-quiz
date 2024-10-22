using System;

namespace Quiz {
    public class Solution {

        public int[] TwoSum(int[] numbers, int target) {
            var left = 0;
            int right = numbers.Length - 1;

            while (left < right) {
                int sum = numbers[left] + numbers[right];
                if (sum == target) {
                    return new[] { left + 1, right + 1 };
                } else {
                    int m = left + (right - left) / 2;
                    if (numbers[left] + numbers[m] >= target) {
                        right = m;
                    } else if (numbers[m] + numbers[right] <= target) {
                        left = m;
                    } else if (sum < target) {
                        left++;
                    } else if (sum > target) {
                        right--;
                    }
                }
            }

            throw new Exception();
        }

    }
}
