namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.WaysToMakeFair, IntArray("[1]"), 1);
            Test.Check(solution.WaysToMakeFair, IntArray("[1,1]"), 1);
            Test.Check(solution.WaysToMakeFair, IntArray("[1,1,2]"), 1);
            Test.Check(solution.WaysToMakeFair, IntArray("[1,1,2,2]"), 0);
            Test.Check(solution.WaysToMakeFair, IntArray("[1,1,2,2,2]"), 3);
            Test.Check(solution.WaysToMakeFair, IntArray("[1,1,1]"), 3);
            Test.Check(solution.WaysToMakeFair, IntArray("[2,1,6,4]"), 1);
            Test.Check(solution.WaysToMakeFair, IntArray("[6,1,7,4,1]"), 0);
            Test.Check(solution.WaysToMakeFair, IntArray("[1,1,1,1,1]"), 5);
        }

    }
}