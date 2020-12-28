namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Print(solution.GenerateParenthesis, 1);
            Test.Print(solution.GenerateParenthesis, 2);
            Test.Print(solution.GenerateParenthesis, 3);
            Test.Print(solution.GenerateParenthesis, 4);
        }

    }
}