namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.MaximumSwap, 0, 0);
            Test.Check(solution.MaximumSwap, 1, 1);
            Test.Check(solution.MaximumSwap, 10, 10);
            Test.Check(solution.MaximumSwap, 11, 11);
            Test.Check(solution.MaximumSwap, 100, 100);
            Test.Check(solution.MaximumSwap, 120, 210);
            Test.Check(solution.MaximumSwap, 2736, 7236);
            Test.Check(solution.MaximumSwap, 9973, 9973);
            Test.Check(solution.MaximumSwap, 12345678, 82345671);
        }

    }
}
