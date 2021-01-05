using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public IList<IList<int>> CombinationSum(int[] candidates, int target) {
            IList<IList<int>> list = new List<IList<int>>();

            Array.Sort(candidates);

            Stack<int> variant = new Stack<int>();

            void deep(int remaining, int start) {
                if (remaining == 0) {
                    if (variant.Count > 0) {
                        list.Add(variant.ToArray());
                    }
                } else {
                    int index = start;
                    while (index < candidates.Length) {
                        int candidate = candidates[index];
                        if (candidate > remaining) {
                            break;
                        }

                        variant.Push(candidate);
                        deep(remaining - candidate, index);
                        variant.Pop();

                        index++;
                    }
                }   
            }
            
            deep(target, 0);

            return list;
        }

    }
}