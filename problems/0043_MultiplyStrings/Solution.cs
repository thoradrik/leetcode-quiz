using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public string AddStrings(IList<string> nums) {
            var ni = new int[nums.Count];

            for (var i = 0; i < nums.Count; i++) {
                ni[i] = nums[i].Length - 1;
            }

            var k = 0;

            var result = new Stack<char>();

            while (true) {
                bool b = k > 0;

                for (var i = 0; i < ni.Length; i++) {
                    b |= ni[i] >= 0;
                }

                if (!b) {
                    break;
                }

                for (var i = 0; i < ni.Length; i++) {
                    if (ni[i] >= 0) {
                        int c = nums[i][ni[i]] - '0';
                        ni[i]--;
                        k += c;
                    }
                }

                result.Push((char)(k % 10 + '0'));

                k /= 10;
            }

            return new string(result.ToArray());
        }

        private string MultiplyHelper(string num1, int num2, int trailing_zeroes) {
            int ai = num1.Length - 1;
            var k = 0;

            var result = new Stack<char>();

            for (var i = 0; i < trailing_zeroes; i++) {
                result.Push('0');
            }

            while (ai >= 0 || k > 0) {
                int c1 = ai >= 0 ? num1[ai--] - '0' : 0;

                k += c1 * num2;

                result.Push((char)(k % 10 + '0'));

                k /= 10;
            }

            return new string(result.ToArray());
        }

        public string Multiply(string num1, string num2) {
            if (num1 == "0" || num2 == "0") {
                return "0";
            } else if (num1 == "1") {
                return num2;
            } else if (num2 == "1") {
                return num1;
            } else if (num1.Length < num2.Length) {
                return Multiply(num2, num1);
            }

            int ai = num2.Length - 1;

            var list = new List<string>(num2.Length);

            for (int i = ai; i >= 0; i--) {
                int n = num2[i] - '0';
                if (n > 0) {
                    int trailing_zeroes = ai - i;
                    list.Add(MultiplyHelper(num1, n, trailing_zeroes));
                }
            }

            if (list.Count > 0) {
                return AddStrings(list);
            } else {
                return "0";
            }
        }

    }
}
