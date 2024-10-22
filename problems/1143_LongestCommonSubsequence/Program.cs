namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.LongestCommonSubsequence, "", "", 0);
            Test.Check(solution.LongestCommonSubsequence, "a", "", 0);
            Test.Check(solution.LongestCommonSubsequence, "a", "b", 0);
            Test.Check(solution.LongestCommonSubsequence, "a", "a", 1);
            Test.Check(solution.LongestCommonSubsequence, "aa", "aa", 2);
            Test.Check(solution.LongestCommonSubsequence, "aaa", "aab", 2);
            Test.Check(solution.LongestCommonSubsequence, "aaa", "aaa", 3);
            Test.Check(solution.LongestCommonSubsequence, "aaab", "aaac", 3);
            Test.Check(solution.LongestCommonSubsequence, "aaab", "aaacaaabaaaa", 4);
        }

    }
}