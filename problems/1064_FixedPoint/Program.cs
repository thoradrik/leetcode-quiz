namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.FixedPoint, IntArray("[1]"), -1);
            Test.Check(solution.FixedPoint, IntArray("[0]"), 0);
            Test.Check(solution.FixedPoint, IntArray("[0,1]"), 0);
            Test.Check(solution.FixedPoint, IntArray("[-1,0,1]"), -1);
            Test.Check(solution.FixedPoint, IntArray("[-1,-2,2,3]"), 2);
            Test.Check(solution.FixedPoint, IntArray("[-10,-5,0,3,7]"), 3);
            Test.Check(solution.FixedPoint, IntArray("[0,2,5,8,17]"), 0);
            Test.Check(solution.FixedPoint, IntArray("[-10,-5,3,4,7,9]"), -1);
            Test.Check(solution.FixedPoint, IntArray("[-9,-8,-7,-5,3,2,6]"), 6);
            Test.Check(solution.FixedPoint, IntArray("[-9,-8,-7,-5,3,2,5,7]"), 7);
            Test.Check(solution.FixedPoint, IntArray("[-9,-8,-7,-5,3,2,5,7,8]"), 7);
            Test.Check(solution.FixedPoint, IntArray("[-9,-8,-7,-5,3,2,5,6,8,9]"), 8);
            Test.Check(solution.FixedPoint, IntArray("[-9,-8,-7,-5,3,2,5,6,7,9]"), 9);
            Test.Check(solution.FixedPoint, IntArray("[-10,-5,-2,0,4,5,6,7,8,9,10]"), 4);
        }

    }
}