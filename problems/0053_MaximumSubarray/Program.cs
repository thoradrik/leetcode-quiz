namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.MaxSubArray, IntArray("[0]"), 0);
            Test.Check(solution.MaxSubArray, IntArray("[1]"), 1);
            Test.Check(solution.MaxSubArray, IntArray("[-1,-2]"), -1);
            Test.Check(solution.MaxSubArray, IntArray("[1,-1]"), 1);
            Test.Check(solution.MaxSubArray, IntArray("[2,-1,1]"), 2);
            Test.Check(solution.MaxSubArray, IntArray("[3,-1,1]"), 3);
            Test.Check(solution.MaxSubArray, IntArray("[3,-1,1,3]"), 6);
            Test.Check(solution.MaxSubArray, IntArray("[3,-1,1,3,-2,5]"), 9);
            Test.Check(solution.MaxSubArray, IntArray("[3,-1,1,3,-2,5,-9,8]"), 9);
            Test.Check(solution.MaxSubArray, IntArray("[-2,1,-3,4,-1,2,1,-5,4]"), 6);
        }

    }
}