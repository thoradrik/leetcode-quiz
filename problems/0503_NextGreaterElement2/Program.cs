namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.NextGreaterElements, IntArray("[]"), IntArray("[]"));
            Test.Check(solution.NextGreaterElements, IntArray("[1]"), IntArray("[-1]"));
            Test.Check(solution.NextGreaterElements, IntArray("[1,1]"), IntArray("[-1,-1]"));
            Test.Check(solution.NextGreaterElements, IntArray("[1,1,2]"), IntArray("[2,2,-1]"));
            Test.Check(solution.NextGreaterElements, IntArray("[3,1,2]"), IntArray("[-1,2,3]"));
            Test.Check(solution.NextGreaterElements, IntArray("[4,3,1,2]"), IntArray("[-1,4,2,4]"));
            Test.Check(solution.NextGreaterElements, IntArray("[4,5,3,1,2]"), IntArray("[5,-1,4,2,4]"));
            Test.Check(solution.NextGreaterElements, IntArray("[6,4,5,3,1,2]"), IntArray("[-1,5,6,6,2,6]"));
            Test.Check(solution.NextGreaterElements, IntArray("[6,4,5,3,6,1,2]"), IntArray("[-1,5,6,6,-1,2,6]"));
        }

    }
}