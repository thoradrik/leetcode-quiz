using System;
using AlgorithmLib;

namespace Quiz {
    public class Solution {

        public string LargestTimeFromDigits(int[] arr) {
            int? max_hm = null;
            
            PermutationGenerator.Generate(arr, a => {
                int h = a[0] * 10 + a[1];
                int m = a[2] * 10 + a[3];
                if (h <= 23 && m <= 59) {
                    int hm = h * 100 + m;
                    if (max_hm.HasValue) {
                        if (hm > max_hm) {
                            max_hm = hm;
                        }
                    } else {
                        max_hm = hm;
                    }
                }
            });

            if (max_hm.HasValue) {
                return String.Format("{0:00}:{1:00}", max_hm / 100, max_hm % 100);
            } else {
                return String.Empty;
            }
        }

    }
}