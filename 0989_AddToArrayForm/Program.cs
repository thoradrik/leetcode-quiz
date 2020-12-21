namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.AddToArrayForm, IntArray("[0]"), 0, IntArray("[0]"));
            Test.Check(solution.AddToArrayForm, IntArray("[0]"), 1, IntArray("[1]"));
            Test.Check(solution.AddToArrayForm, IntArray("[9]"), 1, IntArray("[1,0]"));
            Test.Check(solution.AddToArrayForm, IntArray("[1]"), 9, IntArray("[1,0]"));
            Test.Check(solution.AddToArrayForm, IntArray("[1,0]"), 9, IntArray("[1,9]"));
            Test.Check(solution.AddToArrayForm, IntArray("[1]"), 99, IntArray("[1,0,0]"));
            Test.Check(solution.AddToArrayForm, IntArray("[1,0]"), 999, IntArray("[1,0,0,9]"));
            Test.Check(solution.AddToArrayForm, IntArray("[9,9,9,9,9,9,9]"), 888888, IntArray("[1,0,8,8,8,8,8,7]"));
        }

    }
}