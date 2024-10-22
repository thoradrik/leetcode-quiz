namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            var solution = new Solution();

            // Test.Print(solution.PermuteUnique, IntArray("[1]"));
            // Test.Print(solution.PermuteUnique, IntArray("[1,1]"));
            // Test.Print(solution.PermuteUnique, IntArray("[1,1,1]"));
            // Test.Print(solution.PermuteUnique, IntArray("[1,1,2]"));
            Test.Print(solution.PermuteUnique, IntArray("[1,2,3]"));
            // Test.Print(solution.PermuteUnique, IntArray("[1,1,1,2]"));
            // Test.Print(solution.PermuteUnique, IntArray("[1,1,2,2]"));
            Test.Print(solution.PermuteUnique, IntArray("[-1,2,-1,2,1,-1,2,1]"));
        }

    }
}