using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public string SimilarRGB(string color) {

            int parse_hex(string s, int index) {
                char c = s[index];
                if (c >= '0' && c <= '9') {
                    return c - '0';
                } else {
                    return c - 'a' + 10;
                }
            }

            int parse_hex2(string s, int index) {
                return (parse_hex(s, index) << 4) + parse_hex(s, index + 1);
            }

            int r = parse_hex2(color, 1);
            int g = parse_hex2(color, 3);
            int b = parse_hex2(color, 5);

            IEnumerable<int> values(int c) {
                int h = c >> 4;
                int l = c & 0xF;
                if (h == l) {
                    yield return c;
                } else if (h < l) {
                    yield return (h << 4) + h;
                    yield return ((h + 1) << 4) + (h + 1);
                } else {
                    yield return ((h - 1) << 4) + (h - 1);
                    yield return (h << 4) + h;
                }
            }

            var min_distance = 0xFFFFFF;
            var min_color = 0;

            foreach (int rr in values(r)) {
                foreach (int gg in values(g)) {
                    foreach (int bb in values(b)) {
                        int distance = (r-rr)*(r-rr) + (g-gg)*(g-gg) + (b-bb)*(b-bb);
                        if (distance < min_distance) {
                            min_distance = distance;
                            min_color = (rr << 16) + (gg << 8) + bb;
                        }
                    }
                }
            }

            return String.Format("#{0:x6}", min_color);
        }

    }
}
