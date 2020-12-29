namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.NumSplits, "", 0);
            Test.Check(solution.NumSplits, "a", 0);
            Test.Check(solution.NumSplits, "aa", 1);
            Test.Check(solution.NumSplits, "ab", 1);
            Test.Check(solution.NumSplits, "abc", 0);
            Test.Check(solution.NumSplits, "abcc", 0);
            Test.Check(solution.NumSplits, "abcd", 1);
            Test.Check(solution.NumSplits, "aacaba", 2);
            Test.Check(solution.NumSplits, "abcd", 1);
            Test.Check(solution.NumSplits, "aaaaa", 4);
            Test.Check(solution.NumSplits, "acbadbaada", 2);
        }

    }
}