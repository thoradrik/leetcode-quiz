using System;

namespace Quiz {
    public class Solution {

        public string ReverseStr(string s, int k) {
            char[] chars = s.ToCharArray();

            for (var i = 0; i < s.Length; i += k * 2) {
                for (int start = i, end = Math.Min(chars.Length, i + k) - 1; start < end; start++, end--) {
                    ref char x = ref chars[start];
                    ref char y = ref chars[end];
                    x ^= y;
                    y ^= x;
                    x ^= y;
                }
            }

            return new string(chars);
        }

    }
}
