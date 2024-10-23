namespace Quiz;

public class Program : ProgramBase {

    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.IsMatch, "a", "a", true);
        Test.Check(solution.IsMatch, "a", "b", false);
        Test.Check(solution.IsMatch, "a", ".", true);
        Test.Check(solution.IsMatch, "ab", "a", false);
        Test.Check(solution.IsMatch, "ab", "b", false);
        Test.Check(solution.IsMatch, "ab", "ab", true);
        Test.Check(solution.IsMatch, "ab", "ba", false);
        Test.Check(solution.IsMatch, "ab", "a.", true);
        Test.Check(solution.IsMatch, "ab", ".a", false);
        Test.Check(solution.IsMatch, "ab", ".b", true);
        Test.Check(solution.IsMatch, "aa", ".*", true);
        Test.Check(solution.IsMatch, "ab", ".*", true);
        Test.Check(solution.IsMatch, "ab", "a.b", false);
        Test.Check(solution.IsMatch, "ab", "a.*b", true);
        Test.Check(solution.IsMatch, "aa", "a.", true);
        Test.Check(solution.IsMatch, "aa", "a.*", true);
        Test.Check(solution.IsMatch, "aa", "a*", true);
        Test.Check(solution.IsMatch, "aab", "a*", false);
        Test.Check(solution.IsMatch, "aab", "a*b", true);
        Test.Check(solution.IsMatch, "aab", "a.*b", true);
        Test.Check(solution.IsMatch, "aab", "a.*b", true);
        Test.Check(solution.IsMatch, "aab", "a.*b.", false);
        Test.Check(solution.IsMatch, "aab", "a.*b.*", true);
        Test.Check(solution.IsMatch, "aabb", "a.*b.*", true);
        Test.Check(solution.IsMatch, "aabb", "a.b.", true);
        Test.Check(solution.IsMatch, "aabb", "a*b*", true);
        Test.Check(solution.IsMatch, "aaabbb", "a.b.", false);
        Test.Check(solution.IsMatch, "aaabbb", "a*b*", true);
        Test.Check(solution.IsMatch, "aaaabbbbcccc", "a*b*bccc.", true);
        Test.Check(solution.IsMatch, "aab", "c*a*b", true);
        Test.Check(solution.IsMatch, "aaa", "a*a", true);
        Test.Check(solution.IsMatch, "bacacbacaaabccbcbaa", "a*.c*c*c*a*b*..*", true);
        Test.Check(solution.IsMatch, "baccbbcbcacacbbc", "c*.*b*c*ba*b*b*.a*", true);
        Test.Check(solution.IsMatch, "bacacaababbbcbc", ".*a*.*a*.aa*c*b*c", false);
        Test.Check(solution.IsMatch, "abcaaaaaaabaabcabac", ".ab.a.aa.bb*", false);
        Test.Check(solution.IsMatch, "a", "ab*", true);
    }

}
