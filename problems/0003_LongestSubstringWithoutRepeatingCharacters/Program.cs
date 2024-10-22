namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.LengthOfLongestSubstring, "", 0);
            Test.Check(solution.LengthOfLongestSubstring, "0", 1);
            Test.Check(solution.LengthOfLongestSubstring, "abcabcbb", 3);
            Test.Check(solution.LengthOfLongestSubstring, "bbbbb", 1);
            Test.Check(solution.LengthOfLongestSubstring, "pwwkew", 3);
            Test.Check(solution.LengthOfLongestSubstring, "abcabcdabcdeabca", 5);
        }

    }
}
