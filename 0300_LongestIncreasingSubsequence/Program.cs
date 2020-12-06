using System;
using System.Text.Json;

namespace Quiz {
    public static class Program {
        
        private static void Main(string[] args) {
            Solution solution = new Solution();

            Check(solution.LengthOfLIS, Parse("[]"), 0);
            Check(solution.LengthOfLIS, Parse("[1]"), 1);
            Check(solution.LengthOfLIS, Parse("[1,2]"), 2);
            Check(solution.LengthOfLIS, Parse("[2,1]"), 1);
            Check(solution.LengthOfLIS, Parse("[10,9,2,5,3,7,101,18]"), 4);
            Check(solution.LengthOfLIS, Parse("[0,1,0,3,2,3]"), 4);
            Check(solution.LengthOfLIS, Parse("[7,7,7,7,7,7,7]"), 1);
        }

        private static int[] Parse(string s) {
            return JsonSerializer.Deserialize<int[]>(s);
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