namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.NextGreaterElement, IntArray("[]"), IntArray("[]"), IntArray("[]"));
            Test.Check(solution.NextGreaterElement, IntArray("[1]"), IntArray("[]"), IntArray("[-1]"));
            Test.Check(solution.NextGreaterElement, IntArray("[1]"), IntArray("[1]"), IntArray("[-1]"));
            Test.Check(solution.NextGreaterElement, IntArray("[1]"), IntArray("[1,1]"), IntArray("[-1]"));
            Test.Check(solution.NextGreaterElement, IntArray("[1]"), IntArray("[0,2]"), IntArray("[-1]"));
            Test.Check(solution.NextGreaterElement, IntArray("[1]"), IntArray("[1,0,2]"), IntArray("[2]"));
            Test.Check(solution.NextGreaterElement, IntArray("[1,0]"), IntArray("[1,0,3,2]"), IntArray("[3,3]"));
            Test.Check(solution.NextGreaterElement, IntArray("[2]"), IntArray("[1,2,2]"), IntArray("[-1]"));
            Test.Check(solution.NextGreaterElement, IntArray("[2]"), IntArray("[0,3,1,2,2]"), IntArray("[-1]"));
            Test.Check(solution.NextGreaterElement, IntArray("[2]"), IntArray("[0,4,1,2,2,3,5]"), IntArray("[3]"));
            Test.Check(solution.NextGreaterElement, IntArray("[0,1,2,3,4,5]"), IntArray("[0,4,1,2,2,3,5]"), IntArray("[4,2,3,5,5,-1]"));
            Test.Check(solution.NextGreaterElement, IntArray("[4,1,2]"), IntArray("[1,3,4,2]"), IntArray("[-1,3,-1]"));
            Test.Check(solution.NextGreaterElement, IntArray("[2,4]"), IntArray("[1,2,3,4]"), IntArray("[3,-1]"));
        }

    }
}