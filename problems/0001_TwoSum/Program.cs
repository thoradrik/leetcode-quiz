namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.TwoSum, IntArray("[2,7,11,15]"), 9, IntArray("[0,1]"));
            Test.Check(solution.TwoSum, IntArray("[3,2,4]"), 6, IntArray("[1,2]"));
            Test.Check(solution.TwoSum, IntArray("[3,3]"), 6, IntArray("[0,1]"));
            Test.Check(solution.TwoSum, IntArray("[-2,-1,0,0,3,5]"), 0, IntArray("[2,3]"));
        }

    }
}
