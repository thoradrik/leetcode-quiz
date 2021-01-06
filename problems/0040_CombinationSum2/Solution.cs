using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        private class Candidate {

            public Candidate(int value) {
                Value = value;
                Count = 1;
            }

            public int Value { get; set; }
            
            public int Count { get; set; }

        }

        public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
            Array.Sort(candidates);
            
            List<Candidate> list = new List<Candidate>();

            Candidate item = null;
            foreach (int candidate in candidates) {
                if (item == null) {
                    item = new Candidate(candidate);
                } else if (item.Value == candidate) {
                    item.Count++;
                } else {
                    list.Add(item);
                    item = new Candidate(candidate);
                }
            }

            if (item != null) {
                list.Add(item);
            }
            
            return CombinationSum2(list, target);

        }

        private IList<IList<int>> CombinationSum2(List<Candidate> candidates, int target) {
            IList<IList<int>> list = new List<IList<int>>();

            Stack<int> variant = new Stack<int>();

            void backtrack(int remaining, int start) {
                if (remaining == 0) {
                    if (variant.Count > 0) {
                        list.Add(variant.ToArray());
                    }
                } else {
                    int index = start;
                    while (index < candidates.Count) {
                        Candidate candidate = candidates[index];
                        if (candidate.Value > remaining) {
                            break;
                        }

                        int rem = remaining;
                        int used = 0;
                        
                        while (used < candidate.Count) {
                            variant.Push(candidate.Value);
                            used++;
                            
                            rem -= candidate.Value;
                            
                            if (rem >= 0) {
                                backtrack(rem, index + 1);
                            } else {
                                break;
                            }
                        }

                        while (used > 0) {
                            variant.Pop();
                            used--;
                        }

                        index++;
                    }
                }   
            }
            
            backtrack(target, 0);

            return list;
        }

    }
}