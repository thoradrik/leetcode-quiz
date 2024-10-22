namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.LongestCommonPrefix, new[] { "" }, "");
            Test.Check(solution.LongestCommonPrefix, new[] { "a" }, "a");
            Test.Check(solution.LongestCommonPrefix, new[] { "a", "a" }, "a");
            Test.Check(solution.LongestCommonPrefix, new[] { "a", "a", "a" }, "a");
            Test.Check(solution.LongestCommonPrefix, new[] { "aa", "a", "a" }, "a");
            Test.Check(solution.LongestCommonPrefix, new[] { "a", "a", "aa" }, "a");
            Test.Check(solution.LongestCommonPrefix, new[] { "a", "a", "aa", "a" }, "a");
            Test.Check(solution.LongestCommonPrefix, new[] { "aa", "a", "aa", "aa" }, "a");
            Test.Check(solution.LongestCommonPrefix, new[] { "aa", "aaa", "aa", "aa" }, "aa");
            Test.Check(solution.LongestCommonPrefix, new[] { "aa", "aba", "aa", "aa" }, "a");
            Test.Check(solution.LongestCommonPrefix, new[] { "aa", "aab", "aa", "aa" }, "aa");
            Test.Check(solution.LongestCommonPrefix, new[] { "ba", "aab", "aa", "aa" }, "");
        }

    }
}
