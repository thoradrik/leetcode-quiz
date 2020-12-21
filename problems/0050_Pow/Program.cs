namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.MyPow, 0.0, 0, 1.0);
            Test.Check(solution.MyPow, 0.0, 1, 0.0);
            Test.Check(solution.MyPow, 0.0, 2, 0.0);
            Test.Check(solution.MyPow, 0.0, 3, 0.0);
            Test.Check(solution.MyPow, 1.0, 0, 1.0);
            Test.Check(solution.MyPow, 1.0, 1, 1.0);
            Test.Check(solution.MyPow, 1.0, 2, 1.0);
            Test.Check(solution.MyPow, 1.0, 3, 1.0);
            Test.Check(solution.MyPow, 2.0, 0, 1.0);
            Test.Check(solution.MyPow, 2.0, 1, 2.0);
            Test.Check(solution.MyPow, 2.0, 2, 4.0);
            Test.Check(solution.MyPow, 2.0, 3, 8.0);
            Test.Check(solution.MyPow, 2.0, 10, 1024.0);
            Test.Check(solution.MyPow, 2.0, 11, 2048.0);
            Test.Check(solution.MyPow, 2.1, 3, 9.261);
            Test.Check(solution.MyPow, 2.0, -2, 0.25);
            Test.Check(solution.MyPow, 0.00001, 2147483647, 0.0);
            Test.Check(solution.MyPow, 1.00000, -2147483648, 1.0);
        }

    }
}