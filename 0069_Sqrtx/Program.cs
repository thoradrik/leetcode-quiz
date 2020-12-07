using System;

namespace Quiz {
    public static class Program {
        
        private static void Main(string[] args) {
            Solution solution = new Solution();

            Check(solution.MySqrt, 0, 0);
            Check(solution.MySqrt, 1, 1);
            Check(solution.MySqrt, 2, 1);
            Check(solution.MySqrt, 3, 1);
            Check(solution.MySqrt, 4, 2);
            Check(solution.MySqrt, 8, 2);
            Check(solution.MySqrt, 9, 3);
            Check(solution.MySqrt, 65535, 255);
            Check(solution.MySqrt, 65536, 256);
            Check(solution.MySqrt, 16777215, 4095);
            Check(solution.MySqrt, 16777216, 4096);
            Check(solution.MySqrt, 2147483647, 46340);
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