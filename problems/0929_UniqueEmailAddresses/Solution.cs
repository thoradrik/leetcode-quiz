using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public int NumUniqueEmails(string[] emails) {
            HashSet<string> set = new HashSet<string>();

            foreach (string email in emails) {
                int a_index = email.IndexOf('@', StringComparison.Ordinal);
                
                string name = email.Substring(0, a_index);

                name = name.Replace(".", String.Empty);

                int p_index = name.IndexOf('+', StringComparison.Ordinal);
                if (p_index >= 0) {
                    name = name.Substring(0, p_index);
                }

                string domain = email.Substring(a_index);

                set.Add(name + domain);
            }

            return set.Count;
        }
        
    }
}