namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.ReverseStr, "", 2, "");
            Test.Check(solution.ReverseStr, "a", 2, "a");
            Test.Check(solution.ReverseStr, "ab", 2, "ba");
            Test.Check(solution.ReverseStr, "abc", 2, "bac");
            Test.Check(solution.ReverseStr, "abcd", 2, "bacd");
            Test.Check(solution.ReverseStr, "abcde", 2, "bacde");
            Test.Check(solution.ReverseStr, "abcdef", 2, "bacdfe");
            Test.Check(solution.ReverseStr, "abcdefg", 2, "bacdfeg");
            Test.Check(solution.ReverseStr, "abcdefg", 3, "cbadefg");
            Test.Check(solution.ReverseStr, "abcdefgh", 3, "cbadefhg");
            Test.Check(solution.ReverseStr, "abcdefghi", 3, "cbadefihg");
            Test.Check(solution.ReverseStr, "abcdefghij", 3, "cbadefihgj");
        }

    }
}