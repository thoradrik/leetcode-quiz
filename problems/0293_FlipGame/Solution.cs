using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public IList<string> GeneratePossibleNextMoves(string s) {
            var list = new List<string>();

            for (var i = 0; i < s.Length - 1; i++) {
                if (s[i] == '+' && s[i + 1] == '+') {
                    list.Add(s.Substring(0, i) + "--" + s.Substring(i + 2));
                }
            }

            return list.ToArray();
        }

    }
}
