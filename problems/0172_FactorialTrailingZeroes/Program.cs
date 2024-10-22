namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.TrailingZeroes, 0, 0);
            Test.Check(solution.TrailingZeroes, 1, 0);
            Test.Check(solution.TrailingZeroes, 2, 0);
            Test.Check(solution.TrailingZeroes, 3, 0);
            Test.Check(solution.TrailingZeroes, 4, 0);
            Test.Check(solution.TrailingZeroes, 5, 1);
            Test.Check(solution.TrailingZeroes, 6, 1);
            Test.Check(solution.TrailingZeroes, 7, 1);
            Test.Check(solution.TrailingZeroes, 8, 1);
            Test.Check(solution.TrailingZeroes, 9, 1);
            Test.Check(solution.TrailingZeroes, 10, 2);
            Test.Check(solution.TrailingZeroes, 11, 2);
            Test.Check(solution.TrailingZeroes, 12, 2);
            Test.Check(solution.TrailingZeroes, 13, 2);
            Test.Check(solution.TrailingZeroes, 14, 2);
            Test.Check(solution.TrailingZeroes, 15, 3);
            Test.Check(solution.TrailingZeroes, 16, 3);
            Test.Check(solution.TrailingZeroes, 17, 3);
            Test.Check(solution.TrailingZeroes, 18, 3);
            Test.Check(solution.TrailingZeroes, 19, 3);
            Test.Check(solution.TrailingZeroes, 20, 4);
            Test.Check(solution.TrailingZeroes, 21, 4);
            Test.Check(solution.TrailingZeroes, 22, 4);
            Test.Check(solution.TrailingZeroes, 23, 4);
            Test.Check(solution.TrailingZeroes, 24, 4);
            Test.Check(solution.TrailingZeroes, 25, 6);
            Test.Check(solution.TrailingZeroes, 26, 6);
            Test.Check(solution.TrailingZeroes, 27, 6);
            Test.Check(solution.TrailingZeroes, 28, 6);
            Test.Check(solution.TrailingZeroes, 29, 6);
            Test.Check(solution.TrailingZeroes, 30, 7);
            Test.Check(solution.TrailingZeroes, 56, 13);
            Test.Check(solution.TrailingZeroes, 99, 22);
        }

    }
}
