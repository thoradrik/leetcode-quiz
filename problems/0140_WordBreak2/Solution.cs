using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public IList<string> WordBreak(string s, IList<string> wordDict) {
            int max_length = 0;
            
            HashSet<string> word_hs = new HashSet<string>(wordDict);
            
            HashSet<int> length_hs = new HashSet<int>();
            foreach (string word in wordDict) {
                max_length = Math.Max(max_length, word.Length);
                length_hs.Add(word.Length);
            }
            
            Dictionary<int, List<string>> memo_map = new Dictionary<int, List<string>>();

            List<string> parse(int index) {
                if (memo_map.TryGetValue(index, out List<string> value)) {
                    return value;
                }

                int max_count = s.Length - index;

                List<string> result = new List<string>();

                foreach (int length in length_hs) {
                    if (length <= max_count) {
                        string trial = s.Substring(index, length);
                        if (word_hs.Contains(trial)) {
                            if (length == max_count) {
                                result.Add(trial);
                            } else {
                                foreach (string sub in parse(index + trial.Length)) {
                                    result.Add(trial + " " + sub);
                                }
                            }
                        }
                    }
                }

                memo_map.Add(index, result);
                
                return result;
            }

            return parse(0);
        }
        
    }
}