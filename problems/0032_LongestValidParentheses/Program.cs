namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            // Test.Check(solution.LongestValidParentheses, "", 0);
            // Test.Check(solution.LongestValidParentheses, "(", 0);
            // Test.Check(solution.LongestValidParentheses, ")", 0);
            // Test.Check(solution.LongestValidParentheses, "()", 2);
            // Test.Check(solution.LongestValidParentheses, "(())", 4);
            // Test.Check(solution.LongestValidParentheses, "(())()", 6);
            // Test.Check(solution.LongestValidParentheses, "(())())", 6);
            // Test.Check(solution.LongestValidParentheses, "((())())", 8);
            // Test.Check(solution.LongestValidParentheses, "((())())()", 10);
            // Test.Check(solution.LongestValidParentheses, "((())())()()", 12);
            // Test.Check(solution.LongestValidParentheses, "((())())()())", 12);
            // Test.Check(solution.LongestValidParentheses, "((())())()()))", 12);
            // Test.Check(solution.LongestValidParentheses, ")((())())()()))", 12);
            // Test.Check(solution.LongestValidParentheses, "))((())())()()))", 12);
            Test.Check(solution.LongestValidParentheses, "))((())())()()))(()()()())(())(())", 18);
            
            
        }

    }
}