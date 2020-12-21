namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.LengthOfLIS, IntArray("[]"), 0);
            Test.Check(solution.LengthOfLIS, IntArray("[1]"), 1);
            Test.Check(solution.LengthOfLIS, IntArray("[1,2]"), 2);
            Test.Check(solution.LengthOfLIS, IntArray("[2,1]"), 1);
            Test.Check(solution.LengthOfLIS, IntArray("[10,9,2,5,3,7,101,18]"), 4);
            Test.Check(solution.LengthOfLIS, IntArray("[0,1,0,3,2,3]"), 4);
            Test.Check(solution.LengthOfLIS, IntArray("[7,7,7,7,7,7,7]"), 1);
        }

    }
}