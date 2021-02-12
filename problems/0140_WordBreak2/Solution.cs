using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public IList<string> WordBreak(string s, IList<string> wordDict) {
            HashSet<string> word_hs = new HashSet<string>(wordDict);

            Dictionary<string, HashSet<int>> prefix_map = new Dictionary<string, HashSet<int>>();

            int max_length = 0;
            
            foreach (string word in wordDict) {
                max_length = Math.Max(max_length, word.Length);
                
                for (int i = 1; i <= word.Length; i++) {
                    string prefix = word.Substring(0, i);

                    HashSet<int> count_hs;
                    if (!prefix_map.TryGetValue(prefix, out count_hs)) {
                        count_hs = new HashSet<int>();
                        prefix_map[prefix] = count_hs;
                    }

                    count_hs.Add(word.Length);
                }
            }

            HashSet<int> memo_map = new HashSet<int>();

            IEnumerable<string> parse(int index) {
                if (memo_map.Contains(index)) {
                    yield break;
                }

                int max_count = Math.Min(max_length, s.Length - index);
                
                bool was_result = false;

                HashSet<string> tries = new HashSet<string>();
                
                for (int length = 1; length <= max_count; length++) {
                    string prefix = s.Substring(index, length);
                    if (prefix_map.TryGetValue(prefix, out HashSet<int> count_hs)) {
                        foreach (int count in count_hs) {
                            if (count > max_count) {
                                continue;
                            }
                            string word = s.Substring(index, count);
                            if (word_hs.Contains(word)) {
                                if (!tries.Contains(word)) {
                                    if (index + count >= s.Length) {
                                        was_result = true;
                                        yield return word;
                                    } else {
                                        foreach (string result in parse(index + count)) {
                                            was_result = true;
                                            yield return word + " " + result;
                                        }
                                    }

                                    tries.Add(word);
                                }
                            }
                        }
                    }
                }

                if (!was_result) {
                    memo_map.Add(index);
                }
            }

            return new List<string>(parse(0));
        }
        
    }
}