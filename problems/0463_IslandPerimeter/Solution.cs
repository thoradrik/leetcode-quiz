namespace Quiz {
    public class Solution {

        public int IslandPerimeter(int[][] grid) {
            int m = grid.Length;
            if (m <= 0) {
                return 0;
            }

            int n = grid[0].Length;
            if (n <= 0) {
                return 0;
            }

            var perimeter = 0;

            for (var i = 0; i < m; i++) {
                for (var j = 0; j < n; j++) {
                    if (grid[i][j] == 1) {
                        perimeter += 4;

                        if (i > 0 && grid[i - 1][j] == 1) {
                            perimeter--;
                        }
                        if (i < m - 1 && grid[i + 1][j] == 1) {
                            perimeter--;
                        }
                        if (j > 0 && grid[i][j - 1] == 1) {
                            perimeter--;
                        }
                        if (j < n - 1 && grid[i][j + 1] == 1) {
                            perimeter--;
                        }
                    }
                }
            }

            return perimeter;
        }

    }
}
