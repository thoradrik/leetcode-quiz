using System;

namespace Quiz {
    public static class Program {
        
        private static void Main(string[] args) {
            Solution solution = new Solution();

            Check(solution.MyPow, 0.0, 0, 1.0);
            Check(solution.MyPow, 0.0, 1, 0.0);
            Check(solution.MyPow, 0.0, 2, 0.0);
            Check(solution.MyPow, 0.0, 3, 0.0);
            Check(solution.MyPow, 1.0, 0, 1.0);
            Check(solution.MyPow, 1.0, 1, 1.0);
            Check(solution.MyPow, 1.0, 2, 1.0);
            Check(solution.MyPow, 1.0, 3, 1.0);
            Check(solution.MyPow, 2.0, 0, 1.0);
            Check(solution.MyPow, 2.0, 1, 2.0);
            Check(solution.MyPow, 2.0, 2, 4.0);
            Check(solution.MyPow, 2.0, 3, 8.0);
            Check(solution.MyPow, 2.0, 10, 1024.0);
            Check(solution.MyPow, 2.0, 11, 2048.0);
            Check(solution.MyPow, 2.1, 3, 9.261);
            Check(solution.MyPow, 2.0, -2, 0.25);
            Check(solution.MyPow, 0.00001, 2147483647, 0.0);
            Check(solution.MyPow, 1.00000, -2147483648, 1.0);
        }
        
        private const double EPSILON = 0.00000005;

        private static void Check(Func<double, int, double> func, double test1, int test2, double expected) {
            Console.WriteLine("TEST {0}^{1}", test1, test2);
            
            double answer = func(test1, test2);
            if (Math.Abs(expected - answer) > EPSILON) {
                Console.WriteLine("  !!! FAILED {0} {1}", answer, expected);
            } else {
                Console.WriteLine("  PASSED {0} {1}", answer, expected);
            }
        }

    }
}