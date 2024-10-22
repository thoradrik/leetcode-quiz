using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public int FindMinDifference(IList<string> time_points) {
            var points_hs = new HashSet<int>();

            foreach (string time_point in time_points) {
                string[] parts = time_point.Split(':');

                int point = Int32.Parse(parts[0]) * 60 + Int32.Parse(parts[1]);
                if (points_hs.Contains(point)) {
                    return 0;
                }

                points_hs.Add(point);
            }

            var points = new List<int>();

            foreach (int point in points_hs) {
                points.Add(point);
                points.Add(point + 1440);
            }

            points.Sort();

            int min_distance = points[1] - points[0];

            for (var i = 2; i < points.Count; i++) {
                int point_j = points[i - 1];
                int point_i = points[i];
                min_distance = Math.Min(min_distance, (point_i - point_j) % 1400);
            }

            return min_distance;
        }

    }
}
