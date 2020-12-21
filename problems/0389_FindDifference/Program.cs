namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.FindTheDifference, "abcd", "abcde", 'e');
            Test.Check(solution.FindTheDifference, "", "y", 'y');
            Test.Check(solution.FindTheDifference, "a", "aa", 'a');
            Test.Check(solution.FindTheDifference, "ae", "aea", 'a');
        }

    }
}