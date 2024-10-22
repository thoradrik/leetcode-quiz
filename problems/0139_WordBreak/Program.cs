namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.WordBreak, "aaaaaa", StringArray("[\"aaaa\",\"aa\"]"), true);
            Test.Check(solution.WordBreak, "aaaaaaa", StringArray("[\"aaaa\",\"aa\"]"), false);
            Test.Check(solution.WordBreak, "aaaaaaaa", StringArray("[\"aaaa\",\"aa\"]"), true);
            Test.Check(solution.WordBreak, "leetleep", StringArray("[\"leet\",\"leep\"]"), true);
            Test.Check(solution.WordBreak, "leetleep", StringArray("[\"leet\",\"code\"]"), false);
            Test.Check(solution.WordBreak, "leetcode", StringArray("[\"leet\",\"code\"]"), true);
            Test.Check(solution.WordBreak, "applepenapple", StringArray("[\"apple\",\"pen\"]"), true);
            Test.Check(solution.WordBreak, "catsandog", StringArray("[\"cats\",\"dog\",\"sand\",\"and\",\"cat\"]"), false);
        }

    }
}
