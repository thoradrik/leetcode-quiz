using System.Collections.Generic;
using AlgorithmLib;

namespace Quiz {
    public class Solution {
        
        public string[] Expand(string s) {
            IList<IList<char>> map = new List<IList<char>>();

            List<char> chars = null;
            foreach (char c in s) {
                if (c == '{') {
                    chars = new List<char>();
                } else if (c == '}') {
                    map.Add(chars.ToArray());
                    chars = null;
                } else if (c == ',') {
                    // NOP
                } else {
                    if (chars != null) {
                        chars.Add(c);
                    } else {
                        map.Add(new[] { c });
                    }
                }
            }

            List<string> list = new List<string>();
            
            CombinationGenerator.Generate(
                map.Count,
                map,
                items => list.Add(new string(items))
            );
            
            list.Sort();

            return list.ToArray();
        }
        
    }
}