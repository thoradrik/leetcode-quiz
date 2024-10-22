namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.ReverseParentheses, "", "");
            Test.Check(solution.ReverseParentheses, "a", "a");
            Test.Check(solution.ReverseParentheses, "(a)", "a");
            Test.Check(solution.ReverseParentheses, "(ab)", "ba");
            Test.Check(solution.ReverseParentheses, "(ab)(c)", "bac");
            Test.Check(solution.ReverseParentheses, "(ab)(cd)", "badc");
            Test.Check(solution.ReverseParentheses, "((ba)(cd))", "cdba");
            Test.Check(solution.ReverseParentheses, "(abcd)", "dcba");
            Test.Check(solution.ReverseParentheses, "(u(love)i)", "iloveu");
            Test.Check(solution.ReverseParentheses, "(ed(et(oc))el)", "leetcode");
            Test.Check(solution.ReverseParentheses, "(ed(et(oc))el)", "leetcode");
            Test.Check(solution.ReverseParentheses, "a(bcdefghijkl(mno)p)q", "apmnolkjihgfedcbq");
            Test.Check(solution.ReverseParentheses, "a(bcde()fghijkl(mno)p)q", "apmnolkjihgfedcbq");
        }

    }
}