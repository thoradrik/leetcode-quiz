using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public IList<string> GenerateParenthesis(int n) {
            List<string> list = new List<string>();

            void go_next(string s, int used, int opened) {
                if (s.Length == n * 2) {
                    list.Add(s);
                } else {
                    if (opened > 0) {
                        go_next(s + ")", used, opened - 1);
                    }
                    if (opened < n && used < n) {
                        go_next(s + "(", used + 1, opened + 1);
                    }
                }
            }

            go_next("", 0, 0);
            
            return list;
        }
        
    }
}