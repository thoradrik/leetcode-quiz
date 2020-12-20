using System;

namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();
            
            Test.Check(solution.MyAtoi, "12345", 12345);
            Test.Check(solution.MyAtoi, "+12345", 12345);
            Test.Check(solution.MyAtoi, "-12345", -12345);
            Test.Check(solution.MyAtoi, "+12345-", 12345);
            Test.Check(solution.MyAtoi, "+12345+", 12345);
            Test.Check(solution.MyAtoi, "-12345+", -12345);
            Test.Check(solution.MyAtoi, "-12345-", -12345);
            Test.Check(solution.MyAtoi, "+-12345", 0);
            Test.Check(solution.MyAtoi, "-+12345", 0);
            Test.Check(solution.MyAtoi, "- 12345", 0);
            Test.Check(solution.MyAtoi, "- +12345", 0);
            Test.Check(solution.MyAtoi, "+ -12345", 0);
            Test.Check(solution.MyAtoi, "  12345", 12345);
            Test.Check(solution.MyAtoi, "  +12345", 12345);
            Test.Check(solution.MyAtoi, "  -12345", -12345);
            Test.Check(solution.MyAtoi, "  12345 word", 12345);
            Test.Check(solution.MyAtoi, "  +12345 word", 12345);
            Test.Check(solution.MyAtoi, "  -12345 word", -12345);
            Test.Check(solution.MyAtoi, "  +12.345 word", 12);
            Test.Check(solution.MyAtoi, "  -12.345 word", -12);
            Test.Check(solution.MyAtoi, "  +.345 word", 0);
            Test.Check(solution.MyAtoi, "  -.345 word", 0);
            Test.Check(solution.MyAtoi, "word  +.345 word", 0);
            Test.Check(solution.MyAtoi, "word  -.345 word", 0);
            Test.Check(solution.MyAtoi, "-12345678912345678", Int32.MinValue);
            Test.Check(solution.MyAtoi, "12345678912345678", Int32.MaxValue);
        }

    }
}