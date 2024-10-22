using System.Collections.Generic;
using System.Text;

namespace Quiz {
    public class Solution {

        public IList<IList<string>> GroupStrings(string[] strings) {
            var map = new Dictionary<string, IList<string>>();

            foreach (string s in strings) {
                var sb = new StringBuilder();
                for (var index = 0; index < s.Length; index++) {
                    int k = s[index] - s[0];
                    char c;
                    if (k >= 0) {
                        c = (char) k;
                    } else {
                        c = (char) (26 + k);
                    }
                    sb.Append(c);
                }

                var key = sb.ToString();

                if (!map.TryGetValue(key, out var list)) {
                    list = new List<string>();
                    map[key] = list;
                }

                list.Add(s);
            }

            return new List<IList<string>>(map.Values);
        }

    }
}
