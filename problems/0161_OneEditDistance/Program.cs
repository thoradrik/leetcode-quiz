namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.IsOneEditDistance, "", "", false);
            Test.Check(solution.IsOneEditDistance, "a", "", true);
            Test.Check(solution.IsOneEditDistance, "", "a", true);
            Test.Check(solution.IsOneEditDistance, "a", "a", false);
            Test.Check(solution.IsOneEditDistance, "a", "b", true);
            Test.Check(solution.IsOneEditDistance, "b", "a", true);
            Test.Check(solution.IsOneEditDistance, "aa", "", false);
            Test.Check(solution.IsOneEditDistance, "aa", "a", true);
            Test.Check(solution.IsOneEditDistance, "aa", "aa", false);
            Test.Check(solution.IsOneEditDistance, "aa", "ab", true);
            Test.Check(solution.IsOneEditDistance, "aa", "aba", true);
            Test.Check(solution.IsOneEditDistance, "aa", "abaa", false);
            Test.Check(solution.IsOneEditDistance, "aaa", "abaa", true);
        }

    }
}
