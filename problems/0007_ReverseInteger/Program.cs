using System;

namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.Reverse, 0, 0);
            Test.Check(solution.Reverse, 1, 1);
            Test.Check(solution.Reverse, 2, 2);
            Test.Check(solution.Reverse, 10, 1);
            Test.Check(solution.Reverse, 11, 11);
            Test.Check(solution.Reverse, 12, 21);
            Test.Check(solution.Reverse, 123, 321);
            Test.Check(solution.Reverse, 1234, 4321);
            Test.Check(solution.Reverse, 12345, 54321);
            Test.Check(solution.Reverse, 123456, 654321);
            Test.Check(solution.Reverse, 1234567, 7654321);
            Test.Check(solution.Reverse, 12345678, 87654321);
            Test.Check(solution.Reverse, 123456789, 987654321);
            Test.Check(solution.Reverse, 1234567890, 987654321);
            Test.Check(solution.Reverse, 1234567899, 0);
            Test.Check(solution.Reverse, 1463847412, 02147483641);
            Test.Check(solution.Reverse, 2147483647, 0);
            Test.Check(solution.Reverse, -1, -1);
            Test.Check(solution.Reverse, -2, -2);
            Test.Check(solution.Reverse, -10, -1);
            Test.Check(solution.Reverse, -11, -11);
            Test.Check(solution.Reverse, -12, -21);
            Test.Check(solution.Reverse, -123, -321);
            Test.Check(solution.Reverse, -1234, -4321);
            Test.Check(solution.Reverse, -12345, -54321);
            Test.Check(solution.Reverse, -123456, -654321);
            Test.Check(solution.Reverse, -1234567, -7654321);
            Test.Check(solution.Reverse, -12345678, -87654321);
            Test.Check(solution.Reverse, -123456789, -987654321);
            Test.Check(solution.Reverse, -1234567890, -987654321);
            Test.Check(solution.Reverse, -1234567899, 0);
            Test.Check(solution.Reverse, -2147483648, 0);
        }

    }
}