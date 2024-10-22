namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            // Test.Check(solution.IsValid, "", true);
            // Test.Check(solution.IsValid, "a", false);
            Test.Check(solution.IsValid, "abc", true);
            Test.Check(solution.IsValid, "abcabc", true);
            Test.Check(solution.IsValid, "ababccabc", true);
            Test.Check(solution.IsValid, "abababcccabc", true);
            Test.Check(solution.IsValid, "abababcabcccabc", true);
            Test.Check(solution.IsValid, "abababcababccccabc", true);
            Test.Check(solution.IsValid, "abababcababcabccccabc", true);
            Test.Check(solution.IsValid, "abababcababcabcabccccabc", true);
            Test.Check(solution.IsValid, "abababcababcabcabcabccccabc", true);
            Test.Check(solution.IsValid, "aabcbc", true);
            Test.Check(solution.IsValid, "abcabcababcc", true);
            Test.Check(solution.IsValid, "abccba", false);
        }

    }
}
