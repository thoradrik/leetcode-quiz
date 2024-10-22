namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.LongestPalindrome, "a", "a");
            Test.Check(solution.LongestPalindrome, "ab", "a");
            Test.Check(solution.LongestPalindrome, "abcc", "cc");
            Test.Check(solution.LongestPalindrome, "abccbbb", "bbb");
            Test.Check(solution.LongestPalindrome, "aa", "aa");
            Test.Check(solution.LongestPalindrome, "aaa", "aaa");
            Test.Check(solution.LongestPalindrome, "aaaa", "aaaa");
            Test.Check(solution.LongestPalindrome, "aba", "aba");
            Test.Check(solution.LongestPalindrome, "abac", "aba");
            Test.Check(solution.LongestPalindrome, "cabac", "cabac");
            Test.Check(solution.LongestPalindrome, "xyzcabacxyz", "cabac");
            Test.Check(solution.LongestPalindrome, "xyzcabacxyzyx", "cabac");
            Test.Check(solution.LongestPalindrome, "xyzcabacxyzzyx", "xyzzyx");
            Test.Check(solution.LongestPalindrome, "xyzcabacxyzqzyx", "xyzqzyx");
            Test.Check(solution.LongestPalindrome, "xyzcabbbacxyzqzyx", "cabbbac");
            Test.Check(solution.LongestPalindrome, "zyxcabacxyz", "zyxcabacxyz");
            Test.Check(solution.LongestPalindrome, "babad", "bab");
            Test.Check(solution.LongestPalindrome, "cbbd", "bb");
        }

    }
}
