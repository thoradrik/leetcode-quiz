namespace Quiz;

public class Program : ProgramBase {

    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.LongestContinuousSubstring, "", 0);
        Test.Check(solution.LongestContinuousSubstring, "a", 1);
        Test.Check(solution.LongestContinuousSubstring, "aa", 1);
        Test.Check(solution.LongestContinuousSubstring, "ab", 2);
        Test.Check(solution.LongestContinuousSubstring, "ba", 1);
        Test.Check(solution.LongestContinuousSubstring, "bac", 1);
        Test.Check(solution.LongestContinuousSubstring, "bab", 2);
        Test.Check(solution.LongestContinuousSubstring, "babc", 3);
        Test.Check(solution.LongestContinuousSubstring, "babcba", 3);
        Test.Check(solution.LongestContinuousSubstring, "babcba", 3);
        Test.Check(solution.LongestContinuousSubstring, "bdbcba", 2);
        Test.Check(solution.LongestContinuousSubstring, "abacaba", 2);
        Test.Check(solution.LongestContinuousSubstring, "abcde", 5);
        Test.Check(solution.LongestContinuousSubstring, "abcdetuvwxyz", 7);
    }

}
