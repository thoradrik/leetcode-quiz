namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            // Test.Check(solution.RepeatedSubstringPattern, "", false);
            // Test.Check(solution.RepeatedSubstringPattern, "a", false);
            // Test.Check(solution.RepeatedSubstringPattern, "aa", true);
            // Test.Check(solution.RepeatedSubstringPattern, "aba", false);
            // Test.Check(solution.RepeatedSubstringPattern, "abab", true);
            // Test.Check(solution.RepeatedSubstringPattern, "ababa", false);
            // Test.Check(solution.RepeatedSubstringPattern, "ababab", true);
            // Test.Check(solution.RepeatedSubstringPattern, "ababac", false);
            Test.Check(solution.RepeatedSubstringPattern, "ababacababac", true);
            Test.Check(solution.RepeatedSubstringPattern, "ababacababad", false);
            Test.Check(solution.RepeatedSubstringPattern, "ababacababadababacababad", true);
            Test.Check(solution.RepeatedSubstringPattern, "ababacababadababacababae", false);
            Test.Check(solution.RepeatedSubstringPattern, "ababacababadababacababaeababacababadababacababae", true);
            Test.Check(solution.RepeatedSubstringPattern, "ababacababadababacababaeababacababadababacababaf", false);
            Test.Check(solution.RepeatedSubstringPattern, "ababacababadababacababaeababacababadababacababafababacababadababacababaeababacababadababacababaf", true);
            Test.Check(solution.RepeatedSubstringPattern, "ababacababadababacababaeababacababadababacababafababacababadababacababaeababacababadababacababag", false);
            Test.Check(solution.RepeatedSubstringPattern, "ababacababadababacababaeababacababadababacababafababacababadababacababaeababacababadababacababagababacababadababacababaeababacababadababacababafababacababadababacababaeababacababadababacababag", true);
            Test.Check(solution.RepeatedSubstringPattern, "ababacababadababacababaeababacababadababacababafababacababadababacababaeababacababadababacababagababacababadababacababaeababacababadababacababafababacababadababacababaeababacababadababacababagababacababadababacababaeababacababadababacababafababacababadababacababaeababacababadababacababagababacababadababacababaeababacababadababacababafababacababadababacababaeababacababadababacababag", true);
            Test.Check(solution.RepeatedSubstringPattern, "ababacababadababacababaeababacababadababacababafababacababadababacababaeababacababadababacababagababacababadababacababaeababacababadababacababafababacababadababacababaeababacababadababacababagababacababadababacababaeababacababadababacababafababacababadababacababaeababacababadababacababagababacababadababacababaeababacababadababacababafababacababadababacababaeababacababadababacababagababacababadababacababaeababacababadababacababafababacababadababacababaeababacababadababacababagababacababadababacababaeababacababadababacababafababacababadababacababaeababacababadababacababag", true);
            Test.Check(solution.RepeatedSubstringPattern, "abcabcabcabc", true);
            Test.Check(solution.RepeatedSubstringPattern, "aabaaba", false);
        }

    }
}