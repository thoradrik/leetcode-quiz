namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.MergeAlternately, "a", "b", "ab");
            Test.Check(solution.MergeAlternately, "aa", "b", "aba");
            Test.Check(solution.MergeAlternately, "a", "bb", "abb");
            Test.Check(solution.MergeAlternately, "aa", "bb", "abab");
            Test.Check(solution.MergeAlternately, "aaa", "bb", "ababa");
            Test.Check(solution.MergeAlternately, "aa", "bbb", "ababb");
            Test.Check(solution.MergeAlternately, "aa", "bbbbb", "ababbbb");
            Test.Check(solution.MergeAlternately, "abc", "pqr", "apbqcr");
            Test.Check(solution.MergeAlternately, "ab", "pqrs", "apbqrs");
            Test.Check(solution.MergeAlternately, "abcd", "pq", "apbqcd");
        }

    }
}