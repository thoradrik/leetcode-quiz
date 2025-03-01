﻿namespace Quiz {
    public class Solution {

        public int LengthOfLongestSubstring(string s) {
            if (s.Length <= 0) {
                return 0;
            }

            var max_start = 0;
            var max_length = 0;

            var map = new bool[256];

            var start = 0;
            var length = 1;
            map[s[start]] = true;

            while (start + length < s.Length) {
                int k = start + length;

                if (map[s[k]]) {
                    if (length >= max_length) {
                        // Console.WriteLine("MAX: {0}", s.Substring(start, length));
                        max_start = start;
                        max_length = length;
                    }

                    map[s[start]] = false;
                    start++;

                    if (length > 0) {
                        length--;
                    }

                    goto next;
                }

                // Console.WriteLine("     {0}", s.Substring(start, length));

                map[s[k]] = true;
                length++;
            next:
                ;
            }

            if (length > max_length) {
                // Console.WriteLine("MAX: {0}", s.Substring(start, length));
                max_start = start;
                max_length = length;
            }

            return max_length;
        }

    }
}
