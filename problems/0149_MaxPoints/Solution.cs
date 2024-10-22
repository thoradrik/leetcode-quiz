using System;
using System.Collections.Generic;
using static System.String;

namespace Quiz {
    public class Solution {

        private readonly struct Point : IEquatable<Point> {

            public Point(decimal x, decimal y, int count) {
                X = x;
                Y = y;
                Count = count;
            }

            public decimal X { get; }

            public decimal Y { get; }

            public int Count { get; }

            public bool Equals(Point other) {
                return X == other.X && Y == other.Y;
            }

            public override bool Equals(object obj) {
                return obj is Point other && Equals(other);
            }

            public override int GetHashCode() {
                return HashCode.Combine(X, Y);
            }

        }

        private readonly struct Line : IEquatable<Line> {

            public Line(decimal an, decimal bn, decimal cn) {
                An = an;
                Bn = bn;
                Cn = cn;
            }

            private decimal An { get; }

            private decimal Bn { get; }

            private decimal Cn { get; }

            public bool Equals(Line other) {
                return An == other.An && Bn == other.Bn && Cn == other.Cn;
            }

            public override bool Equals(object obj) {
                return obj is Line other && Equals(other);
            }

            public override int GetHashCode() {
                return HashCode.Combine(An, Bn, Cn);
            }

            public override string ToString() {
                return Format("An: {0}, Bn: {1}, Cn: {2}", An, Bn, Cn);
            }

        }

        public static decimal Sqrt(decimal x, decimal epsilon = 0.0M) {
            if (x < 0) throw new OverflowException("Cannot calculate square root from a negative number");

            decimal current = (decimal)Math.Sqrt((double)x), previous;
            do {
                previous = current;
                if (previous == 0.0M) {
                    return 0;
                }
                current = (previous + x / previous) / 2;
            } while (Math.Abs(previous - current) > epsilon);

            return current;
        }

        public int MaxPoints(int[][] points) {
            if (points.Length == 0) return 0;

            var ps_hs = new Dictionary<Tuple<int, int>, int>();

            foreach (int[] point in points) {
                var t = new Tuple<int, int>(point[0], point[1]);

                if (!ps_hs.TryGetValue(t, out int count)) {
                    ps_hs[t] = 1;
                } else {
                    ps_hs[t] = count + 1;
                }
            }

            var ps = new List<Point>();

            foreach (var pair in ps_hs) {
                var key = pair.Key;
                ps.Add(new Point(key.Item1, key.Item2, pair.Value));
            }

            if (ps.Count == 1) return ps[0].Count;

            ps.Sort((a, b) => (int)a.X * (int)b.Y - (int)b.X * (int)a.Y);

            var line_map = new Dictionary<Line, HashSet<Point>>();

            for (var i = 0; i < ps.Count; i++) {
                for (int j = i + 1; j < ps.Count; j++) {
                    decimal a = ps[i].Y - ps[j].Y;
                    decimal b = ps[j].X - ps[i].X;
                    decimal c = ps[i].X * ps[j].Y - ps[j].X * ps[i].Y;
                    decimal n = Sqrt(a * a + b * b);
                    decimal an = a / n;
                    decimal bn = b / n;
                    decimal cn = c / n;
                    var line = new Line(an, bn, cn);

                    if (!line_map.TryGetValue(line, out var line_ps)) {
                        line_ps = new HashSet<Point>();
                        line_map[line] = line_ps;
                    }

                    line_ps.Add(ps[i]);
                    line_ps.Add(ps[j]);
                }
            }

            var max = 0;

            foreach (var pair in line_map) {
                var hs = pair.Value;

                var count = 0;

                foreach (var p in hs) {
                    count += p.Count;
                }

                if (count > max) {
                    max = count;
                }
            }

            return max;
        }

    }
}
