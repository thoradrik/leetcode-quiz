namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Print(solution.RemoveInvalidParentheses, ")(");
            Test.Print(solution.RemoveInvalidParentheses, ")(aaa");
            Test.Print(solution.RemoveInvalidParentheses, "aaa)(bbb");
            Test.Print(solution.RemoveInvalidParentheses, "aaa)(bbb)");
            Test.Print(solution.RemoveInvalidParentheses, "()())()");
            Test.Print(solution.RemoveInvalidParentheses, "(a)())()");
            Test.Print(solution.RemoveInvalidParentheses, "))((");
            Test.Print(solution.RemoveInvalidParentheses, "(a)b)c(d(e(fgh)");
        }

    }
}
