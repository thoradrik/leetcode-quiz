using System.Collections.Generic;
using System.Text;

namespace Quiz {
    public class Solution {
        
        public IList<IList<string>> GroupStrings(string[] strings) {
            Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();
            
            foreach (string s in strings) {
                StringBuilder sb = new StringBuilder();
                for (int index = 0; index < s.Length; index++) {
                    int k = s[index] - s[0];
                    char c;
                    if (k >= 0) {
                        c = (char) k;
                    } else {
                        c = (char) (26 + k);
                    }
                    sb.Append(c);
                }

                string key = sb.ToString();

                if (!map.TryGetValue(key, out IList<string> list)) {
                    list = new List<string>();
                    map[key] = list;
                }
                
                list.Add(s);
            }

            return new List<IList<string>>(map.Values);
        }
        
    }
}