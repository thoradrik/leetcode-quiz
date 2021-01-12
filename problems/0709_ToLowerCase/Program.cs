namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.ToLowerCase, "", "");
            Test.Check(solution.ToLowerCase, "a", "a");
            Test.Check(solution.ToLowerCase, "A", "a");
            Test.Check(solution.ToLowerCase, "1", "1");
            Test.Check(solution.ToLowerCase, "Ab", "ab");
            Test.Check(solution.ToLowerCase, "AB", "ab");
            Test.Check(solution.ToLowerCase, "LEETcode", "leetcode");
            Test.Check(solution.ToLowerCase, "LeetCode", "leetcode");
        }

    }
}