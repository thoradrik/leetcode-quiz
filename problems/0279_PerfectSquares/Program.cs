namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.NumSquares, 1, 1);
            Test.Check(solution.NumSquares, 2, 2);
            Test.Check(solution.NumSquares, 3, 3);
            Test.Check(solution.NumSquares, 5, 2);
            Test.Check(solution.NumSquares, 8, 2);
            Test.Check(solution.NumSquares, 9, 1);
            Test.Check(solution.NumSquares, 10, 2);
            Test.Check(solution.NumSquares, 12, 3);
            Test.Check(solution.NumSquares, 121, 1);
            Test.Check(solution.NumSquares, 1212, 4);
            Test.Check(solution.NumSquares, 12124, 4);
            Test.Check(solution.NumSquares, 121245, 3);
            Test.Check(solution.NumSquares, 1212456, 3);
        }

    }
}