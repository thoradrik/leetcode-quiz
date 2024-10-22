namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.CheckRecord, 1, 3);
            Test.Check(solution.CheckRecord, 2, 8);
            Test.Check(solution.CheckRecord, 3, 19);
            Test.Check(solution.CheckRecord, 10101, 183236316);
        }

    }
}
