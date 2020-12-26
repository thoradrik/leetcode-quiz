namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            // Test.Check(solution.GenerateParenthesis, 1, StringArray("[\"()\"]"));
            Test.Check(solution.GenerateParenthesis, 2, StringArray("[\"()()\",\"(())\"]"));
            Test.Check(solution.GenerateParenthesis, 3, StringArray("[\"()()()\",\"(()())\",\"()(())\",\"((()))\",\"(())()\"]"));
            Test.Check(solution.GenerateParenthesis, 4, StringArray("[\"(((())))\",\"((()()))\",\"((())())\",\"((()))()\",\"(()(()))\",\"(()()())\",\"(()())()\",\"(())(())\",\"(())()()\",\"()((()))\",\"()(()())\",\"()(())()\",\"()()(())\",\"()()()()\"]"));
        }

    }
}