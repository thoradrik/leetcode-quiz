namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.RunningSum, IntArray("[]"), IntArray("[]"));
            Test.Check(solution.RunningSum, IntArray("[0]"), IntArray("[0]"));
            Test.Check(solution.RunningSum, IntArray("[-10]"), IntArray("[-10]"));
            Test.Check(solution.RunningSum, IntArray("[1,2]"), IntArray("[1,3]"));
            Test.Check(solution.RunningSum, IntArray("[0,1,2]"), IntArray("[0,1,3]"));
            Test.Check(solution.RunningSum, IntArray("[-1,0,1]"), IntArray("[-1,-1,0]"));
            Test.Check(solution.RunningSum, IntArray("[1,2,3,4]"), IntArray("[1,3,6,10]"));
            Test.Check(solution.RunningSum, IntArray("[1,1,1,1,1]"), IntArray("[1,2,3,4,5]"));
        }

    }
}