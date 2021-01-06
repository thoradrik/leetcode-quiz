namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Print(solution.CombinationSum2, IntArray("[10,1,2,7,6,1,5]"), 8);
            Test.Print(solution.CombinationSum2, IntArray("[2,5,2,1,2]"), 5);
        }

    }
}