namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.SuperPow, 0, IntArray("[0]"), 1);
            Test.Check(solution.SuperPow, 0, IntArray("[1]"), 0);
            Test.Check(solution.SuperPow, 0, IntArray("[2]"), 0);
            Test.Check(solution.SuperPow, 0, IntArray("[3]"), 0);
            Test.Check(solution.SuperPow, 1, IntArray("[0]"), 1);
            Test.Check(solution.SuperPow, 1, IntArray("[1]"), 1);
            Test.Check(solution.SuperPow, 1, IntArray("[3]"), 1);
            Test.Check(solution.SuperPow, 1, IntArray("[3]"), 1);
            Test.Check(solution.SuperPow, 2, IntArray("[0]"), 1);
            Test.Check(solution.SuperPow, 2, IntArray("[1]"), 2);
            Test.Check(solution.SuperPow, 2, IntArray("[2]"), 4);
            Test.Check(solution.SuperPow, 2, IntArray("[3]"), 8);
            Test.Check(solution.SuperPow, 2, IntArray("[1,0]"), 1024);
            Test.Check(solution.SuperPow, 2, IntArray("[1,1]"), 711);
            Test.Check(solution.SuperPow, 2, IntArray("[1,0,1]"), 1019);
            Test.Check(solution.SuperPow, 1, IntArray("[4,3,3,8,5,2]"), 1);
            Test.Check(solution.SuperPow, 2147483647, IntArray("[2,0,0]"), 1198);
        }

    }
}