﻿using System.Collections.Generic;
using AlgorithmLib;

namespace Quiz {
    public class Solution {

        public IList<IList<int>> SubsetsWithDup(int[] nums) {
            var nums_map = new Dictionary<int, int>();

            foreach (int num in nums) {
                if (nums_map.TryGetValue(num, out int count)) {
                    nums_map[num] = count + 1;
                } else {
                    nums_map[num] = 1;
                }
            }

            var map = new (int, int)[nums_map.Count];

            var i = 0;
            foreach (var pair in nums_map) {
                map[i++] = (pair.Key, pair.Value);
            }

            IList<IList<int>> list = new List<IList<int>>();

            CombinationGenerator.Generate(
                map.Length,
                ptr => map[ptr].Item2 + 1,
                (ptr, index) => index,
                counts => {
                    var items = new List<int>();

                    for (var ptr = 0; ptr < counts.Length; ptr++) {
                        int count = counts[ptr];
                        while (count > 0) {
                            items.Add(map[ptr].Item1);
                            count--;
                        }
                    }

                    list.Add(items);
                }
            );

            return list;
        }

    }
}
