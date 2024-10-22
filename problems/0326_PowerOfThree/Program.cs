namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.IsPowerOfThree, 1, true);
            Test.Check(solution.IsPowerOfThree, 2, false);
            Test.Check(solution.IsPowerOfThree, 3, true);
            Test.Check(solution.IsPowerOfThree, 6, false);
            Test.Check(solution.IsPowerOfThree, 9, true);
            Test.Check(solution.IsPowerOfThree, 10, false);
            Test.Check(solution.IsPowerOfThree, 15, false);
            Test.Check(solution.IsPowerOfThree, 16, false);
            Test.Check(solution.IsPowerOfThree, 27, true);
            Test.Check(solution.IsPowerOfThree, 81, true);
            Test.Check(solution.IsPowerOfThree, 243, true);
            Test.Check(solution.IsPowerOfThree, 729, true);
            Test.Check(solution.IsPowerOfThree, 2187, true);
            Test.Check(solution.IsPowerOfThree, 6561, true);
            Test.Check(solution.IsPowerOfThree, 19683, true);
            Test.Check(solution.IsPowerOfThree, 59049, true);
            Test.Check(solution.IsPowerOfThree, 216513, false);
            Test.Check(solution.IsPowerOfThree, 649539, false);
            Test.Check(solution.IsPowerOfThree, 1948617, false);
            Test.Check(solution.IsPowerOfThree, 177147, true);
            Test.Check(solution.IsPowerOfThree, 531441, true);
            Test.Check(solution.IsPowerOfThree, 1594323, true);
            Test.Check(solution.IsPowerOfThree, 4782969, true);
            Test.Check(solution.IsPowerOfThree, 14348907, true);
            Test.Check(solution.IsPowerOfThree, 43046721, true);
            Test.Check(solution.IsPowerOfThree, 129140163, true);
            Test.Check(solution.IsPowerOfThree, 387420489, true);
            Test.Check(solution.IsPowerOfThree, 1162261467, true);
            Test.Check(solution.IsPowerOfThree, -1162261467, false);
            Test.Check(solution.IsPowerOfThree, -9, false);
        }

    }
}
