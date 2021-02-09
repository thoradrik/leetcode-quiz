using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public IList<IList<int>> SubsetsWithDup(int[] nums) {
            Dictionary<int, int> nums_map = new Dictionary<int, int>();
            
            foreach (int num in nums) {
                if (nums_map.TryGetValue(num, out int count)) {
                    nums_map[num] = count + 1;
                } else {
                    nums_map[num] = 1;
                }
            }
            
            (int, int)[] map = new (int, int)[nums_map.Count];
            
            int i = 0;
            foreach (KeyValuePair<int,int> pair in nums_map) {
                map[i++] = (pair.Key, pair.Value);
            }

            IList<IList<int>> list = new List<IList<int>>();
            
            GenerateCombinations(ptr => map[ptr].Item2 + 1, map.Length, counts => {
                List<int> items = new List<int>();
                
                for (int ptr = 0; ptr < counts.Length; ptr++) {
                    int count = counts[ptr];
                    while (count > 0) {
                        items.Add(map[ptr].Item1);
                        count--;
                    }
                }
                
                list.Add(items);
            });  
            
            return list;
        }

        public static void GenerateCombinations(Func<int, int> array_length, int length, Action<int[]> output) {
            int[] stack = new int[length];
            int ptr = 0;
            
            int[] result = new int[length];
            do {
                if (ptr < length) {
                    int index = stack[ptr];
                    if (index < array_length(ptr)) {
                        result[ptr] = index;
                        ptr++;
                    } else {
                        stack[ptr] = 0;
                        ptr--;
                        if (ptr < 0) {
                            break;
                        } else {
                            stack[ptr]++;
                        }
                    }
                } else {
                    output(result);
                    ptr--;
                    stack[ptr]++;
                }
            } while (true);
        }
        
    }
}