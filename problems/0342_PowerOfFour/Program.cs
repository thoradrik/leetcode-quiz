namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.IsPowerOfFour, 0, false);
            Test.Check(solution.IsPowerOfFour, 1, true);
            Test.Check(solution.IsPowerOfFour, 2, false);
            Test.Check(solution.IsPowerOfFour, 3, false);
            Test.Check(solution.IsPowerOfFour, 4, true);
            Test.Check(solution.IsPowerOfFour, 8, false);
            Test.Check(solution.IsPowerOfFour, 16, true);
            Test.Check(solution.IsPowerOfFour, 32, false);
            Test.Check(solution.IsPowerOfFour, 64, true);
            Test.Check(solution.IsPowerOfFour, 128, false);
            Test.Check(solution.IsPowerOfFour, 256, true);
            Test.Check(solution.IsPowerOfFour, 512, false);
            Test.Check(solution.IsPowerOfFour, 1024, true);
            Test.Check(solution.IsPowerOfFour, -1024, false);
            Test.Check(solution.IsPowerOfFour, 1073741824, true);
            Test.Check(solution.IsPowerOfFour, 2147483647, false);
            Test.Check(solution.IsPowerOfFour, -2147483648, false);
        }

    }
}
