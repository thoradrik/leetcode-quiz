namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();
            
            Test.Check(solution.Method, IntArray("[]"), IntArray("[]"), IntArray("[]"));
            Test.Check(solution.Method, IntArray("[1]"), IntArray("[]"), IntArray("[1]"));
            Test.Check(solution.Method, IntArray("[]"), IntArray("[1]"), IntArray("[1]"));
            Test.Check(solution.Method, IntArray("[1]"), IntArray("[2]"), IntArray("[1,2]"));
            Test.Check(solution.Method, IntArray("[1,2]"), IntArray("[3]"), IntArray("[1,3,2]"));
            Test.Check(solution.Method, IntArray("[1,2,3]"), IntArray("[4]"), IntArray("[1,4,2,3]"));
            Test.Check(solution.Method, IntArray("[1,2]"), IntArray("[3,4,5,6]"), IntArray("[1,3,2,4,5,6]"));
        }

    }
}