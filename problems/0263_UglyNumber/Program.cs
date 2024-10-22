namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.IsUgly, -1024, false);
            Test.Check(solution.IsUgly, -2, false);
            Test.Check(solution.IsUgly, -3, false);
            Test.Check(solution.IsUgly, -5, false);
            Test.Check(solution.IsUgly, 0, false);
            Test.Check(solution.IsUgly, 1, false);
            Test.Check(solution.IsUgly, 2, true);
            Test.Check(solution.IsUgly, 3, true);
            Test.Check(solution.IsUgly, 5, true);
            Test.Check(solution.IsUgly, 6, true);
            Test.Check(solution.IsUgly, 7, false);
            Test.Check(solution.IsUgly, 8, true);
            Test.Check(solution.IsUgly, 9, true);
            Test.Check(solution.IsUgly, 1073741824, true);
            Test.Check(solution.IsUgly, 1073741823, false);
            Test.Check(solution.IsUgly, 2147483647, false);
            Test.Check(solution.IsUgly, -2147483644, false);
        }

    }
}
