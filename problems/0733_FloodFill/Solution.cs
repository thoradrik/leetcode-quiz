namespace Quiz {
    public class Solution {
        
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
            int m = image.Length;
            if (m <= 0) {
                return image;
            }
            
            int n = image[0].Length;
            if (n <= 0) {
                return image;
            }
            
            int old_color = image[sr][sc];
            if (old_color == newColor) {
                return image;
            }

            void dfs(int x, int y) {
                image[x][y] = newColor;
                
                if (x < m - 1 && image[x + 1][y] == old_color) dfs(x + 1, y);
                if (y < n - 1 && image[x][y + 1] == old_color) dfs(x, y + 1);
                if (x > 0 && image[x - 1][y] == old_color) dfs(x - 1, y);
                if (y > 0 && image[x][y - 1] == old_color) dfs(x, y - 1);
            }

            dfs(sr, sc);

            return image;
        }
        
    }
}