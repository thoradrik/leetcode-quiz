using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz {
    public class Solution {

        private class Cell : IEquatable<Cell> {

            public Cell(int height, int width) {
                Height = height;
                Width = width;
            }

            public int Height;

            public int Width;

            public int Area => Height * Width;
            
            public override string ToString() => Height + "x" + Width;

            public bool Equals(Cell other) {
                if (ReferenceEquals(null, other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Height == other.Height && Width == other.Width;
            }

            public override bool Equals(object obj) {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((Cell) obj);
            }

            public override int GetHashCode() => HashCode.Combine(Height, Width);

        }
        
        public int MaximalRectangle(char[][] matrix) {
            int height = matrix.Length;
            if (height <= 0) {
                return 0;
            }
            int width = matrix[0].Length;

            HashSet<Cell>[,] dp = new HashSet<Cell>[height + 1, width + 1];

            int max_area = 0;
            
            for (int i = height - 1; i >= 0; i--) {
                for (int j = width - 1; j >= 0; j--) {
                    if (matrix[i][j] != '1') continue;

                    HashSet<Cell> current = new HashSet<Cell>();
                    
                    HashSet<Cell> nexts = dp[i, j + 1];
                    HashSet<Cell> bottoms = dp[i + 1, j];
                    if (nexts == null && bottoms == null) {
                        current.Add(new Cell(1, 1));
                    } else if (nexts != null && bottoms == null) {
                        int max_width = nexts.Max(c => c.Width);
                        current.Add(new Cell(1, max_width + 1));
                    } else if (nexts == null) {
                        int max_height = bottoms.Max(c => c.Height);
                        current.Add(new Cell(max_height + 1, 1));
                    } else {
                        foreach (Cell bottom in bottoms) {
                            foreach (Cell next in nexts) {
                                current.Add(new Cell(bottom.Height + 1,  Math.Min(bottom.Width, next.Width + 1)));
                                current.Add(new Cell(Math.Min(bottom.Height + 1, next.Height), next.Width + 1));
                            }
                        }
                    }

                    dp[i, j] = current;
                    
                    foreach (Cell cell in current) {
                        max_area = Math.Max(max_area, cell.Area);
                    }
                }
            }

            return max_area;
        }

    }
}