namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.SingleNumber, IntArray("[0]"), 0);
            Test.Check(solution.SingleNumber, IntArray("[1]"), 1);
            Test.Check(solution.SingleNumber, IntArray("[0,1,0]"), 1);
            Test.Check(solution.SingleNumber, IntArray("[0,2,0]"), 2);
            Test.Check(solution.SingleNumber, IntArray("[0,2,1,0,2]"), 1);
            Test.Check(solution.SingleNumber, IntArray("[-1,0,2,1,0,2,-1]"), 1);
            Test.Check(solution.SingleNumber, IntArray("[-5,-1,0,2,10,-5,0,2,-1]"), 10);
            Test.Check(solution.SingleNumber, IntArray("[23456,-5,-1,0,2,10,23456,-5,0,2,-1]"), 10);
            Test.Check(solution.SingleNumber, IntArray("[23456,-5,-1,0,2,10,23456,-5,0,2,-1,10,66]"), 66);
        }

    }
}