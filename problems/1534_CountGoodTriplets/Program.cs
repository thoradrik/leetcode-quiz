namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.CountGoodTriplets, IntArray("[3,0,1,1,9,7]"), 7, 2, 3, 4);
            Test.Check(solution.CountGoodTriplets, IntArray("[1,1,2,2,3]"), 0, 0, 1, 0);
        }

    }
}