namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.SolveEquation, "x=0", "x=0");
            Test.Check(solution.SolveEquation, "x=1", "x=1");
            Test.Check(solution.SolveEquation, "1=0", "No solution");
            Test.Check(solution.SolveEquation, "0=0", "Infinite solutions");
            Test.Check(solution.SolveEquation, "-1-x=1", "x=-2");
            Test.Check(solution.SolveEquation, "1-x=1", "x=0");
            Test.Check(solution.SolveEquation, "1-x=-1", "x=2");
            Test.Check(solution.SolveEquation, "x+5-3+x=6+x-2", "x=2");
            Test.Check(solution.SolveEquation, "x=x", "Infinite solutions");
            Test.Check(solution.SolveEquation, "2x=x", "x=0");
            Test.Check(solution.SolveEquation, "2x+3x-6x=x+2", "x=-1");
            Test.Check(solution.SolveEquation, "x=x+2", "No solution");
        }

    }
}