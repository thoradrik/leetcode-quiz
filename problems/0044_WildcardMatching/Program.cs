namespace Quiz;

public class Program : ProgramBase {

    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.IsMatch, "a", "a", true);
        Test.Check(solution.IsMatch, "a", "a", true);
        Test.Check(solution.IsMatch, "a", "b", false);
        Test.Check(solution.IsMatch, "a", "?", true);
        Test.Check(solution.IsMatch, "ab", "a", false);
        Test.Check(solution.IsMatch, "ab", "b", false);
        Test.Check(solution.IsMatch, "ab", "ab", true);
        Test.Check(solution.IsMatch, "ab", "ba", false);
        Test.Check(solution.IsMatch, "ab", "a?", true);
        Test.Check(solution.IsMatch, "ab", "?a", false);
        Test.Check(solution.IsMatch, "ab", "?b", true);
        Test.Check(solution.IsMatch, "aa", "*", true);
        Test.Check(solution.IsMatch, "ab", "*", true);
        Test.Check(solution.IsMatch, "ab", "a?b", false);
        Test.Check(solution.IsMatch, "ab", "a*b", true);
        Test.Check(solution.IsMatch, "aa", "a?", true);
        Test.Check(solution.IsMatch, "aa", "a*", true);
        Test.Check(solution.IsMatch, "aab", "a*", true);
        Test.Check(solution.IsMatch, "aab", "a?b", true);
        Test.Check(solution.IsMatch, "aab", "a*b", true);
        Test.Check(solution.IsMatch, "aab", "a*b", true);
        Test.Check(solution.IsMatch, "aab", "a*b?", false);
        Test.Check(solution.IsMatch, "aab", "a*b*", true);
        Test.Check(solution.IsMatch, "aabb", "a*b*", true);
        Test.Check(solution.IsMatch, "aabb", "a?b?", true);
        Test.Check(solution.IsMatch, "aabb", "a?b*", true);
        Test.Check(solution.IsMatch, "aabb", "a*b?", true);
        Test.Check(solution.IsMatch, "aaabbb", "a?b?", false);
        Test.Check(solution.IsMatch, "aaabbb", "aa?b??", true);
        Test.Check(solution.IsMatch, "aaabbb", "aa?b?a", false);
        Test.Check(solution.IsMatch, "aaabbb", "a??bb?", true);
        Test.Check(solution.IsMatch, "aaabbb", "aa?bb?", true);
        Test.Check(solution.IsMatch, "aaabbb", "a??b??", true);
        Test.Check(solution.IsMatch, "aaabbb", "a??b?b", true);
        Test.Check(solution.IsMatch, "aaabbb", "a**b*b", true);
        Test.Check(solution.IsMatch, "aaabbb", "a**b**b", true);
        Test.Check(solution.IsMatch, "aaabbb", "a**b***", true);
        Test.Check(solution.IsMatch, "aaabbb", "a**b***c", false);
        Test.Check(solution.IsMatch, "aaabbb", "a*b*", true);
        Test.Check(solution.IsMatch, "aaaabaaaabbbbaabbbaabbaababbabbaaaababaaabbbbbbaabbbabababbaaabaabaaaaaabbaabbbbaababbababaabbbaababbbba", "*****b*aba***babaa*bbaba***a*aaba*b*aa**a*b**ba***a*a*", true);
        Test.Check(solution.IsMatch, "abbabaaabbabbaababbabbbbbabbbabbbabaaaaababababbbabababaabbababaabbbbbbaaaabababbbaabbbbaabbbbababababbaabbaababaabbbababababbbbaaabbbbbabaaaabbababbbbaababaabbababbbbbababbbabaaaaaaaabbbbbaabaaababaaaabb", "**aa*****ba*a*bb**aa*ab****a*aaaaaa***a*aaaa**bbabb*b*b**aaaaaaaaa*a********ba*bbb***a*ba*bb*bb**a*b*bb", false);
    }

}
