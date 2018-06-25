using System;

namespace Quiz {
    public static class Program {
        
        private static void Main(string[] args) {
            Solution solution = new Solution();
            
            Check(solution, "12345", 12345);
            Check(solution, "+12345", 12345);
            Check(solution, "-12345", -12345);
            Check(solution, "+12345-", 12345);
            Check(solution, "+12345+", 12345);
            Check(solution, "-12345+", -12345);
            Check(solution, "-12345-", -12345);
            Check(solution, "+-12345", 0);
            Check(solution, "-+12345", 0);
            Check(solution, "- 12345", 0);
            Check(solution, "- +12345", 0);
            Check(solution, "+ -12345", 0);
            Check(solution, "  12345", 12345);
            Check(solution, "  +12345", 12345);
            Check(solution, "  -12345", -12345);
            Check(solution, "  12345 word", 12345);
            Check(solution, "  +12345 word", 12345);
            Check(solution, "  -12345 word", -12345);
            Check(solution, "  +12.345 word", 12);
            Check(solution, "  -12.345 word", -12);
            Check(solution, "  +.345 word", 0);
            Check(solution, "  -.345 word", 0);
            Check(solution, "word  +.345 word", 0);
            Check(solution, "word  -.345 word", 0);
            Check(solution, "-12345678912345678", Int32.MinValue);
            Check(solution, "12345678912345678", Int32.MaxValue);

        }

        private static void Check(Solution solution, string str, int check) {
            int result = solution.MyAtoi(str);
            if (result != check) {
                Console.WriteLine("'{0}' got {1} expected {2}", str, result, check);
            }
        }

    }
}