using System;

namespace Quiz {
    public static class Program {
        
        private static void Main(string[] args) {
            Solution solution = new Solution();

            Check(solution.LengthOfLongestSubstring, "", 0);
            Check(solution.LengthOfLongestSubstring, "0", 1);
            Check(solution.LengthOfLongestSubstring, "abcabcbb", 3);
            Check(solution.LengthOfLongestSubstring, "bbbbb", 1);
            Check(solution.LengthOfLongestSubstring, "pwwkew", 3);
            Check(solution.LengthOfLongestSubstring, "abcabcdabcdeabca", 5);
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