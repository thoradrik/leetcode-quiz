namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.CanPermutePalindrome, "a", true);
            Test.Check(solution.CanPermutePalindrome, "aa", true);
            Test.Check(solution.CanPermutePalindrome, "ab", false);
            Test.Check(solution.CanPermutePalindrome, "aaa", true);
            Test.Check(solution.CanPermutePalindrome, "aab", true);
            Test.Check(solution.CanPermutePalindrome, "aabc", false);
            Test.Check(solution.CanPermutePalindrome, "aabcc", true);
            Test.Check(solution.CanPermutePalindrome, "aabbcc", true);
            Test.Check(solution.CanPermutePalindrome, "daabbcc", true);
            Test.Check(solution.CanPermutePalindrome, "edaabbcc", false);
        }

    }
}
