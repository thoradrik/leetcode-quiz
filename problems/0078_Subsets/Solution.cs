using System.Collections.Generic;
using AlgorithmLib;

namespace Quiz {
    public class Solution {

        public IList<IList<int>> Subsets(int[] nums) {
            IList<IList<int>> list = new List<IList<int>>();

            CombinationGenerator.Generate(nums.Length, new[] { false, true }, flags => {
                var items = new List<int>();

                for (var index = 0; index < flags.Length; index++) {
                    if (flags[index]) {
                        items.Add(nums[index]);
                    }
                }

                list.Add(items);
            });

            return list;
        }

    }
}
