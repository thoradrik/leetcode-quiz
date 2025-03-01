﻿using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public int MaxAreaOfIsland(int[][] grid) {
            int m = grid.Length;
            if (m <= 0) {
                return 0;
            }

            int n = grid[0].Length;
            if (n <= 0) {
                return 0;
            }

            var dp = new int[m, n];

            var number = 0;
            var max_square = 0;

            var stack = new Stack<Tuple<int, int>>();

            void push(Tuple<int, int> ptr, int ox, int oy) {
                int x = ptr.Item1 + ox;
                int y = ptr.Item2 + oy;

                if (x >= 0 && y >= 0 && x < m && y < n) {
                    if (grid[x][y] == 1) {
                        if (dp[x,y] <= 0) {
                            stack.Push(new Tuple<int, int>(x, y));
                        }
                    }
                }
            }

            for (var i = 0; i < m; i++) {
                for (var j = 0; j < n; j++) {
                    if (grid[i][j] == 1) {
                        if (dp[i, j] <= 0) {
                            number++;

                            var points = new HashSet<Tuple<int, int>>();

                            stack.Push(new Tuple<int, int>(i, j));

                            while (stack.TryPop(out var c)) {
                                dp[c.Item1, c.Item2] = number;

                                points.Add(c);

                                push(c, -1, 0);
                                push(c, 0, -1);
                                push(c, 1, 0);
                                push(c, 0, 1);
                            }

                            max_square = Math.Max(max_square, points.Count);
                        }
                    }
                }
            }

            return max_square;
        }

    }
}
