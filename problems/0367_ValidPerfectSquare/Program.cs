namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.IsPerfectSquare, 0, true);
            Test.Check(solution.IsPerfectSquare, 1, true);
            Test.Check(solution.IsPerfectSquare, 2, false);
            Test.Check(solution.IsPerfectSquare, 3, false);
            Test.Check(solution.IsPerfectSquare, 4, true);
            Test.Check(solution.IsPerfectSquare, 8, false);
            Test.Check(solution.IsPerfectSquare, 9, true);
            Test.Check(solution.IsPerfectSquare, 65535, false);
            Test.Check(solution.IsPerfectSquare, 65536, true);
            Test.Check(solution.IsPerfectSquare, 16777215, false);
            Test.Check(solution.IsPerfectSquare, 16777216, true);
            Test.Check(solution.IsPerfectSquare, 2147483647, false);
        }

    }
}
