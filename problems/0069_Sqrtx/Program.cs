namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.MySqrt, 0, 0);
            Test.Check(solution.MySqrt, 1, 1);
            Test.Check(solution.MySqrt, 2, 1);
            Test.Check(solution.MySqrt, 3, 1);
            Test.Check(solution.MySqrt, 4, 2);
            Test.Check(solution.MySqrt, 8, 2);
            Test.Check(solution.MySqrt, 9, 3);
            Test.Check(solution.MySqrt, 65535, 255);
            Test.Check(solution.MySqrt, 65536, 256);
            Test.Check(solution.MySqrt, 16777215, 4095);
            Test.Check(solution.MySqrt, 16777216, 4096);
            Test.Check(solution.MySqrt, 2147483647, 46340);
        }

    }
}
