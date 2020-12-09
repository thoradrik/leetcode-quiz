using System;
using System.Text.Json;

namespace Quiz {
    public static class Program {
        
        private static void Main(string[] args) {
            Solution solution = new Solution();

            Check(solution.SuperPow, 0, "[0]", 1);
            Check(solution.SuperPow, 0, "[1]", 0);
            Check(solution.SuperPow, 0, "[2]", 0);
            Check(solution.SuperPow, 0, "[3]", 0);
            Check(solution.SuperPow, 1, "[0]", 1);
            Check(solution.SuperPow, 1, "[1]", 1);
            Check(solution.SuperPow, 1, "[3]", 1);
            Check(solution.SuperPow, 1, "[3]", 1);
            Check(solution.SuperPow, 2, "[0]", 1);
            Check(solution.SuperPow, 2, "[1]", 2);
            Check(solution.SuperPow, 2, "[2]", 4);
            Check(solution.SuperPow, 2, "[3]", 8);
            Check(solution.SuperPow, 2, "[1,0]", 1024);
            Check(solution.SuperPow, 2, "[1,1]", 711);
            Check(solution.SuperPow, 2, "[1,0,1]", 1019);
            Check(solution.SuperPow, 1, "[4,3,3,8,5,2]", 1);
            Check(solution.SuperPow, 2147483647, "[2,0,0]", 1198);
        }
        
        private const double EPSILON = 00000005;

        private static void Check(Func<int, int[], int> func, int test1, string test2, int expected) {
            Console.WriteLine("TEST {0}^{1} mod 1337", test1, test2);
            
            double answer = func(test1, JsonSerializer.Deserialize<int[]>(test2));
            if (Math.Abs(expected - answer) > EPSILON) {
                Console.WriteLine("  !!! FAILED {0} {1}", answer, expected);
            } else {
                Console.WriteLine("  PASSED {0} {1}", answer, expected);
            }
        }

    }
}