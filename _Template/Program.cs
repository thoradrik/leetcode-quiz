using System;

namespace Quiz {
    public static class Program {
        
        private static void Main(string[] args) {
            Solution solution = new Solution();

            Check(solution, 1, 1);
        }

        private static void Check(Solution solution, int test, int expected) {
            Console.WriteLine("TEST {0}", test);
            
            int answer = solution.Method(test);
            if (expected != answer) {
                Console.WriteLine("  !!! FAILED {0} {1}", answer, expected);
            } else {
                Console.WriteLine("  PASSED {0} {1}", answer, expected);
            }
        }

    }
}