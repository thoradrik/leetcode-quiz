using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        private class Pair {

            public int Start;
            
            public int End;
            
            public int Length;
            
            public int Memo;

        }

        private class IntReverseComparer : IComparer<int> {

            public int Compare(int x, int y) => y - x;

        }
        
        public int LongestPalindromeSubseq(string s) {
            SortedDictionary<int, List<Pair>> pair_map = new SortedDictionary<int, List<Pair>>(new IntReverseComparer());

            for (int start = 0; start < s.Length; start++) {
                for (int end = start; end < s.Length; end++) {
                    if (s[start] == s[end]) {
                        int length = end - start + 1;

                        if (!pair_map.TryGetValue(length, out List<Pair> list)) {
                            list = new List<Pair>();
                            pair_map[length] = list;
                        }
                        
                        list.Add(new Pair {
                            Start = start,
                            End = end,
                            Length = length,
                            Memo = length <= 3 ? length : 0
                        });
                    }
                }    
            }

            int compose(Pair outer) {
                int max = 0;
                
                foreach ((int key, List<Pair> pairs) in pair_map) {
                    if (key >= outer.Length - 1) continue;
                    if (max >= key) break;
                    
                    for (int index = 0; index < pairs.Count; index++) {
                        Pair pair = pairs[index];
                        if (pair.Start > outer.Start && pair.End < outer.End) {
                            max = Math.Max(
                                max, 
                                pair.Memo > 0 ? pair.Memo + 2 : compose(pair) + 2
                            );
                        }
                    }
                }

                outer.Memo = max;

                return max;
            }

            return compose(new Pair {
                Length = s.Length + 2, 
                Start = -1, 
                End = s.Length + 1
            }) - 2;
        } 

    }
}