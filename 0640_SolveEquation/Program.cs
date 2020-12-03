using System;

namespace Quiz {
    public static class Program {
        
        private static void Main(string[] args) {
            Solution solution = new Solution();

            Check(solution.SolveEquation, "x=0", "x=0");
            Check(solution.SolveEquation, "x=1", "x=1");
            Check(solution.SolveEquation, "1=0", "No solution");
            Check(solution.SolveEquation, "0=0", "Infinite solutions");
            Check(solution.SolveEquation, "-1-x=1", "x=-2");
            Check(solution.SolveEquation, "1-x=1", "x=0");
            Check(solution.SolveEquation, "1-x=-1", "x=2");
            Check(solution.SolveEquation, "x+5-3+x=6+x-2", "x=2");
            Check(solution.SolveEquation, "x=x", "Infinite solutions");
            Check(solution.SolveEquation, "2x=x", "x=0");
            Check(solution.SolveEquation, "2x+3x-6x=x+2", "x=-1");
            Check(solution.SolveEquation, "x=x+2", "No solution");
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