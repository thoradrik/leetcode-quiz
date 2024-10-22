using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        private char[][] CHARS = {
            /* 2 */ new[] { 'a', 'b', 'c' },
            /* 3 */ new[] { 'd', 'e', 'f' },
            /* 4 */ new[] { 'g', 'h', 'i' },
            /* 5 */ new[] { 'j', 'k', 'l' },
            /* 6 */ new[] { 'm', 'n', 'o' },
            /* 7 */ new[] { 'p', 'q', 'r', 's' },
            /* 8 */ new[] { 't', 'u', 'v' },
            /* 9 */ new[] { 'w', 'x', 'y', 'z' },
        };

        public IList<string> LetterCombinations(string digits) {
            var list = new List<string>();

            if (digits.Length > 0) {
                var depth = 0;

                var indexes = new int[digits.Length];
                var buffer = new char[digits.Length];

                while (true) {
                    if (depth >= indexes.Length) {
                        list.Add(new string(buffer));
                        depth--;
                        indexes[depth]++;
                    } else {
                        int digit = digits[depth] - '2';
                        char[] chars = CHARS[digit];

                        int index = indexes[depth];
                        if (index >= chars.Length) {
                            if (depth > 0) {
                                indexes[depth] = 0;
                                depth--;
                                indexes[depth]++;
                            } else {
                                break;
                            }
                        } else {
                            buffer[depth] = chars[index];
                            depth++;
                        }
                    }
                }
            }

            return list;
        }

    }
}
