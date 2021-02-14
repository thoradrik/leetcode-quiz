using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public bool WordBreak(string s, IList<string> wordDict) {
            int max_length = 0;
            
            HashSet<string> word_hs = new HashSet<string>(wordDict);
            
            HashSet<int> length_hs = new HashSet<int>();
            foreach (string word in wordDict) {
                max_length = Math.Max(max_length, word.Length);
                length_hs.Add(word.Length);
            }

            HashSet<int> memo_map = new HashSet<int>();

            bool try_parse(int index) {
                if (memo_map.Contains(index)) {
                    return false;
                }

                int max_count = s.Length - index;
                
                foreach (int length in length_hs) {
                    if (length <= max_count) {
                        string trial = s.Substring(index, length);
                        if (word_hs.Contains(trial)) {
                            if (length == max_count) {
                                return true;
                            } else if (try_parse(index + trial.Length)) {
                                return true;
                            }
                        }
                    }
                }

                memo_map.Add(index);
                
                return false;
            }
            
            return try_parse(0);
        }
        
    }
}