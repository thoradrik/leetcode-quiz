namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.LargestAltitude, IntArray("[-5,1,5,0,-7]"), 1);
            Test.Check(solution.LargestAltitude, IntArray("[-4,-3,-2,-1,4,3,2]"), 0);
        }

    }
}