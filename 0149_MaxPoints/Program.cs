using System;
using System.Text;

namespace Quiz {
    public static class Program {
        
        private static void Main(string[] args) {
            Solution solution = new Solution();

            // Check(solution, new int[][] { }, 0);
            // Check(solution, new[] { new[] { 0, 0 } }, 1);
            // Check(solution, new[] { new[] { 0, 0 }, new[] { 0, 0 } }, 2);
            // Check(solution, new[] { new[] { 0, 0 }, new[] { 0, 0 }, new[] { 1, 1 }, new[] { 1, 1 } }, 4);
            // Check(solution, new[] { new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 } }, 3);
            // Check(solution, new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 } }, 3);
            // Check(solution, new[] { new[] { 1, 1 }, new[] { 3, 2 }, new[] { 5,3 }, new[] { 4,1 }, new[] { 2,3 }, new[] { 1,4 } }, 4);
            Check(solution, new[] { new[] { 84,250 }, new[] { 0,0 }, new[] { 1,0 }, new[] { 0,-70 }, new[] { 0,-70 }, new[] { 1,-1 }, new[] { 21,10}, new[] { 42,90 } , new[] { -42,-230 } }, 6);
        }

        private static string Dump(int[][] a) {
            StringBuilder sb = new StringBuilder();
            
            sb.Append("[");
            for (int i = 0; i < a.Length; i++) {
                if (i != 0) {
                    sb.Append(",");
                }
                sb.Append("[");
                for (int j = 0; j < a[i].Length; j++) {
                    if (j != 0) {
                        sb.Append(",");
                    }
                    sb.Append(a[i][j]);
                }    
                sb.Append("]");
            }
            sb.Append("]");
            
            return sb.ToString();
        } 

        private static void Check(Solution solution, int[][] test, int expected) {
            Console.WriteLine("TEST {0}", Dump(test));
            
            int answer = solution.MaxPoints(test);
            if (expected != answer) {
                Console.WriteLine("  !!! FAILED {0} {1}", answer, expected);
            } else {
                Console.WriteLine("  PASSED {0} {1}", answer, expected);
            }
        }

    }
}