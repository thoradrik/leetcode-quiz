namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.ValidPalindrome, "", true);
            Test.Check(solution.ValidPalindrome, "a", true);
            Test.Check(solution.ValidPalindrome, "ab", true);
            Test.Check(solution.ValidPalindrome, "aba", true);
            Test.Check(solution.ValidPalindrome, "abba", true);
            Test.Check(solution.ValidPalindrome, "abdba", true);
            Test.Check(solution.ValidPalindrome, "abdgba", true);
            Test.Check(solution.ValidPalindrome, "abgdba", true);
            Test.Check(solution.ValidPalindrome, "abdggba", true);
            Test.Check(solution.ValidPalindrome, "abdgeba", false);
            Test.Check(solution.ValidPalindrome, "abac", true);
            Test.Check(solution.ValidPalindrome, "abacd", false);
            Test.Check(solution.ValidPalindrome, "dabacd", true);
            Test.Check(solution.ValidPalindrome, "cdabacd", false);
            Test.Check(solution.ValidPalindrome, "cdabacd", false);
            Test.Check(solution.ValidPalindrome, "cdabacdc", true);
            Test.Check(solution.ValidPalindrome, "cdcabacdc", true);
            Test.Check(solution.ValidPalindrome, "cdcxabacdc", true);
            Test.Check(solution.ValidPalindrome, "cdcxabaxcdc", true);
            Test.Check(solution.ValidPalindrome, "cdcxabzaxcdc", true);
            Test.Check(solution.ValidPalindrome, "cdcxaybzaxcdc", false);
        }

    }
}
