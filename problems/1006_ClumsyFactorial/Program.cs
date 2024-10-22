namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.Clumsy, 0, 0);
            Test.Check(solution.Clumsy, 1, 1);
            Test.Check(solution.Clumsy, 2, 2 * 1);
            Test.Check(solution.Clumsy, 3, 3 * 2 / 1);
            Test.Check(solution.Clumsy, 4, 4 * 3 / 2 + 1);
            Test.Check(solution.Clumsy, 5, 5 * 4 / 3 + 2 - 1);
            Test.Check(solution.Clumsy, 6, 6 * 5 / 4 + 3 - 2 * 1);
            Test.Check(solution.Clumsy, 7, 7 * 6 / 5 + 4 - 3 * 2 / 1);
            Test.Check(solution.Clumsy, 8, 8 * 7 / 6 + 5 - 4 * 3 / 2 + 1);
            Test.Check(solution.Clumsy, 9, 9 * 8 / 7 + 6 - 5 * 4 / 3 + 2 - 1);
            Test.Check(solution.Clumsy, 10, 10 * 9 / 8 + 7 - 6 * 5 / 4 + 3 - 2 * 1);
        }

    }
}
