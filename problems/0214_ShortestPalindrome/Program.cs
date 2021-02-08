namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.ShortestPalindrome, "", "");
            Test.Check(solution.ShortestPalindrome, "a", "a");
            Test.Check(solution.ShortestPalindrome, "ab", "bab");
            Test.Check(solution.ShortestPalindrome, "aa", "aa");
            Test.Check(solution.ShortestPalindrome, "aba", "aba");
            Test.Check(solution.ShortestPalindrome, "abba", "abba");
            Test.Check(solution.ShortestPalindrome, "abbac", "cabbac");
            Test.Check(solution.ShortestPalindrome, "aacecaaa", "aaacecaaa");
            Test.Check(solution.ShortestPalindrome, "abcd", "dcbabcd");
        }

    }
}