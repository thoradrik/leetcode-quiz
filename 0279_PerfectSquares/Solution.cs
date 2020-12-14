using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        private static readonly Dictionary<int, int> MAP = new Dictionary<int, int> {
            { 0, 0 }, 
            { 1, 1 }, 
            { 2, 2 }, 
            { 3, 3 }, 
            { 4, 1 }, 
            { 5, 2 }, 
            { 9, 1 }, 
            { 10, 2 } 
        };

        public int NumSquares(int n) {
            if (MAP.TryGetValue(n, out int result)) {
                return result;
            }
            
            int n_sq = (int)Math.Sqrt(n);
            
            int min = Int32.MaxValue;
            
            for (int k = n_sq; k >= 1; k--) {
                int squares = NumSquares(n - k * k) + 1;
                if (squares <= 2) {
                    min = squares;
                    break;
                }
                if (squares < min) {
                    min = squares;
                }
            }

            MAP[n] = min;

            return min;
        }
        
        /*

        // OPTIMAL MATH SOLUTION (NOT MINE UNFORTUNATELY)

        public bool IsPerfectSquare(int num) {
            int k = (int)Math.Sqrt(num);
            return num == k * k;
        }
        
        public int NumSquares(int n) {
            while (n % 4 == 0) {
                n /= 4;
            }

            if (n % 8 == 7) {
                return 4;
            }
            
            if (IsPerfectSquare(n)) {
                return 1;
            }
            
            for (int i = 1; i * i <= n; ++i) {
                if (IsPerfectSquare(n - i * i)) {
                    return 2;
                }
            }

            return 3;
        }

        */
        
    }
}