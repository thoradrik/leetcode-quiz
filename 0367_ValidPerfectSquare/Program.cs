using System;

namespace Quiz {
    public static class Program {
        
        private static void Main(string[] args) {
            Solution solution = new Solution();

            Check(solution.IsPerfectSquare, 0, true);
            Check(solution.IsPerfectSquare, 1, true);
            Check(solution.IsPerfectSquare, 2, false);
            Check(solution.IsPerfectSquare, 3, false);
            Check(solution.IsPerfectSquare, 4, true);
            Check(solution.IsPerfectSquare, 8, false);
            Check(solution.IsPerfectSquare, 9, true);
            Check(solution.IsPerfectSquare, 65535, false);
            Check(solution.IsPerfectSquare, 65536, true);
            Check(solution.IsPerfectSquare, 16777215, false);
            Check(solution.IsPerfectSquare, 16777216, true);
            Check(solution.IsPerfectSquare, 2147483647, false);
        }

        private static void Check<T, R>(Func<T, R> func, T test, R expected) {
            Console.WriteLine("TEST {0}", test);
            
            R answer = func(test);
            if (!Equals(expected, answer)) {
                Console.WriteLine("  !!! FAILED {0} {1}", answer, expected);
            } else {
                Console.WriteLine("  PASSED {0} {1}", answer, expected);
            }
        }

    }
}