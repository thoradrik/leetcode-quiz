using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        private class IntReverseComparer : IComparer<int> {

            public int Compare(int x, int y) => y - x;

        }
        
        public string LongestWord(string[] words) {
            HashSet<string> word_hs = new HashSet<string>(words);

            SortedDictionary<int, SortedSet<string>> length_map = new SortedDictionary<int, SortedSet<string>>(new IntReverseComparer());
            
            foreach (string word in words) {
                if (!length_map.TryGetValue(word.Length, out SortedSet<string> length_words)) {
                    length_words = new SortedSet<string>();
                    length_map[word.Length] = length_words;
                }

                length_words.Add(word);
            }

            foreach ((int length, SortedSet<string> length_words) in length_map) {
                foreach (string length_word in length_words) {
                    for (int prefix_length = 1; prefix_length < length; prefix_length++) {
                        string prefix = length_word.Substring(0, prefix_length);
                        if (!word_hs.Contains(prefix)) {
                            goto next_word;
                        }
                    }

                    return length_word;
                    
                next_word: 
                    ;
                }
            }

            return null;
        }
        
    }
}