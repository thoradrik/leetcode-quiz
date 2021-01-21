using System;

namespace Quiz {
    public class Solution {
        
        public int MaximalSquare(char[][] matrix) {
            int max_height = matrix.Length;
            if (max_height <= 0) {
                return 0;
            }
            int max_width = matrix[0].Length;
            if (max_width <= 0) {
                return 0;
            }

            int[,] dp = new int[max_height + 1, max_width + 1];

            int max_area = 0;

            for (int row = max_height - 1; row >= 0; row--) {
                for (int col = max_width - 1; col >= 0; col--) {
                    int length = 0;

                    if (matrix[row][col] == '1') {
                        int length_n = dp[row + 1, col + 1];
                        int length_r = dp[row + 1, col];
                        int length_b = dp[row, col + 1];
                        if (length_n > 0 && length_r > 0 && length_b > 0) {
                            length = Math.Min(length_n, Math.Min(length_r, length_b)) + 1;
                        } else {
                            length = 1;
                        }
                    }
                    
                    max_area = Math.Max(max_area, length * length);
                    
                    dp[row, col] = length;
                }   
            }
            
            
            return max_area;
        }
        
    }
}