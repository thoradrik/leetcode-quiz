using System;

namespace Quiz {
    public class Solution {

        /*
        public int FindPoisonedDuration(int[] timeSeries, int duration) {
            if (timeSeries.Length <= 0 || duration <= 0) {
                return 0;
            }

            int start = -1;
            int end = -1;

            int total = 0;

            for (int index = 0; index < timeSeries.Length; index++) {
                int time = timeSeries[index];

                if (start >= 0) {
                    if (time < start) {
                        throw new NotImplementedException();
                    } else {
                        if (time < end) {
                            total += time - start;
                        } else {
                            total += end - start;
                        }
                    }
                }

                start = time;
                end = time + duration;
            }

            if (start > 0) {
                total += end - start;
            }

            return total;
        }
        */

        public int FindPoisonedDuration(int[] timeSeries, int duration) {
            if (timeSeries.Length == 0) {
                return 0;
            }
            if (timeSeries.Length == 1) {
                return duration;
            }

            var total = 0;

            for (var index = 1; index < timeSeries.Length; index++) {
                int gap = timeSeries[index] - timeSeries[index - 1];
                total += Math.Min(gap, duration);
            }

            return total + duration;
        }

    }
}
