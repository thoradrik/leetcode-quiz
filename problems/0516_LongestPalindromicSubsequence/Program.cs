namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.LongestPalindromeSubseq, "a", 1);
            Test.Check(solution.LongestPalindromeSubseq, "ab", 1);
            Test.Check(solution.LongestPalindromeSubseq, "aa", 2);
            Test.Check(solution.LongestPalindromeSubseq, "aab", 2);
            Test.Check(solution.LongestPalindromeSubseq, "aabb", 2);
            Test.Check(solution.LongestPalindromeSubseq, "aabbb", 3);
            Test.Check(solution.LongestPalindromeSubseq, "aabbba", 5);
            Test.Check(solution.LongestPalindromeSubseq, "aabbbaa", 7);
            Test.Check(solution.LongestPalindromeSubseq, "paabbbaa", 7);
            Test.Check(solution.LongestPalindromeSubseq, "paabbbaaq", 7);
            Test.Check(solution.LongestPalindromeSubseq, "qaabbbaaq", 9);
            Test.Check(solution.LongestPalindromeSubseq, "ppaabbbaa", 7);
            Test.Check(solution.LongestPalindromeSubseq, "aabbbaaqpaabbbaa", 7);
            Test.Check(solution.LongestPalindromeSubseq, "aabbbbaaqpaabbbaa", 8);
        }

    }
}