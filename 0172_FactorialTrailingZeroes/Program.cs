using System;

namespace Quiz {
    public static class Program {
        
        private static void Main(string[] args) {
            Solution solution = new Solution();

            Check(solution, 0, 0);
            Check(solution, 1, 0);
            Check(solution, 2, 0);
            Check(solution, 3, 0);
            Check(solution, 4, 0);
            Check(solution, 5, 1);
            Check(solution, 6, 1);
            Check(solution, 7, 1);
            Check(solution, 8, 1);
            Check(solution, 9, 1);
            Check(solution, 10, 2);
            Check(solution, 11, 2);
            Check(solution, 12, 2);
            Check(solution, 13, 2);
            Check(solution, 14, 2);
            Check(solution, 15, 3);
            Check(solution, 16, 3);
            Check(solution, 17, 3);
            Check(solution, 18, 3);
            Check(solution, 19, 3);
            Check(solution, 20, 4);
            Check(solution, 21, 4);
            Check(solution, 22, 4);
            Check(solution, 23, 4);
            Check(solution, 24, 4);
            Check(solution, 25, 6);
            Check(solution, 26, 6);
            Check(solution, 27, 6);
            Check(solution, 28, 6);
            Check(solution, 29, 6);
            Check(solution, 30, 7);
            Check(solution, 56, 13);
            Check(solution, 99, 22);
        }

        private static void Check(Solution solution, int n, int expected) {
            Console.WriteLine("CHECK {0}", n);
            
            int answer = solution.TrailingZeroes(n);
            if (expected != answer) {
                Console.WriteLine("  !!! FAILED {0} {1}", answer, expected);
            } else {
                Console.WriteLine("  PASSED {0}  {1}", answer, expected);
            }
        }

    }
}