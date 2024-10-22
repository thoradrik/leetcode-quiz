namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.ReverseWords, "", "");
            Test.Check(solution.ReverseWords, "a", "a");
            Test.Check(solution.ReverseWords, "ab", "ba");
            Test.Check(solution.ReverseWords, "abc", "cba");
            Test.Check(solution.ReverseWords, "abc e", "cba e");
            Test.Check(solution.ReverseWords, "abc ef", "cba fe");
            Test.Check(solution.ReverseWords, "abc efg", "cba gfe");
            Test.Check(solution.ReverseWords, "abc efgh", "cba hgfe");
            Test.Check(solution.ReverseWords, "abc efgh i", "cba hgfe i");
            Test.Check(solution.ReverseWords, "abc efgh ij", "cba hgfe ji");
            Test.Check(solution.ReverseWords, "Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc");
        }

    }
}
