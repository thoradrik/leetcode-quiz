namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.TwoSum, IntArray("[2,7,11,15]"), 9, IntArray("[1,2]"));
            Test.Check(solution.TwoSum, IntArray("[2,3,4]"), 6, IntArray("[1,3]"));
            Test.Check(solution.TwoSum, IntArray("[-1,0]"), -1, IntArray("[1,2]"));
        }

    }
}