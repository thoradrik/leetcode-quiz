using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        private static readonly string[][] HOURS = {
            /* 0 */ new[] { "0" },
            /* 1 */ new[] { "1","2","4","8" },
            /* 2 */ new[] { "3","5","6","9","10" },
            /* 3 */ new[] { "7","11" }
        };

        private static readonly string[][] MINUTES = {
            /* 0 */ new[] { "00" },
            /* 1 */ new[] { "01","02","04","08","16","32" },
            /* 2 */ new[] { "03","05","06","09","10","12","17","18","20","24","33","34","36","40","48" },
            /* 3 */ new[] { "07","11","13","14","19","21","22","25","26","28","35","37","38","41","42","44","49","50","52","56" },
            /* 4 */ new[] { "15","23","27","29","30","39","43","45","46","51","53","54","57","58"},
            /* 5 */ new[] { "31","47","55","59" }
        };

        public IList<string> ReadBinaryWatch(int num) {
            var list = new List<string>();

            for (var i = 0; i < Math.Min(HOURS.Length, num + 1); i++) {
                string[] hours = HOURS[i];
                if (num - i < MINUTES.Length) {
                    string[] minutes = MINUTES[num - i];
                    foreach (string hour in hours) {
                        foreach (string minute in minutes) {
                            list.Add(String.Format("{0}:{1}", hour, minute));
                        }
                    }
                }
            }

            return list;
        }

    }
}
