using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmLib;

namespace Quiz {
    public class Solution {
        
        public string NextClosestTime(string time) {
            int hh = Int32.Parse(time.Substring(0, 1));
            int hl = Int32.Parse(time.Substring(1, 1));
            int mh = Int32.Parse(time.Substring(3, 1));
            int ml = Int32.Parse(time.Substring(4, 1));

            int i_time = hh * 1000 + hl * 100 + mh * 10 + ml;

            HashSet<int> digits_hs = new HashSet<int>();
            digits_hs.Add(hh);
            digits_hs.Add(hl);
            digits_hs.Add(mh);
            digits_hs.Add(ml);

            int[] digits = digits_hs.ToArray();

            int min_time = i_time + 10000;
            
            CombinationGenerator.Generate(4, digits, a => {
                if (a[0] > 2) return;
                if (a[2] > 5) return;
                
                int v_h = a[0] * 10 + a[1];
                int v_m = a[2] * 10 + a[3];
                if (v_h <= 23 && v_m <= 59) {
                    // Console.WriteLine("{0}{1}:{2}{3}", a[0], a[1], a[2], a[3]);
                
                    int v_time = v_h * 100 + v_m;
                    if (v_time != i_time) {
                        if (v_time < i_time) {
                            v_time += 10000;
                        }
                        min_time = Math.Min(v_time, min_time);
                    }
                }
            });

            min_time %= 10000;
            
            return String.Format("{0:00}:{1:00}", min_time / 100, min_time % 100);
        }
        
    }
}