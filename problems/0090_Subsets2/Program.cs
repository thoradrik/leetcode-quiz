namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            // Test.Print(solution.SubsetsWithDup, IntArray("[]"));
            // Test.Print(solution.SubsetsWithDup, IntArray("[0]"));
            // Test.Print(solution.SubsetsWithDup, IntArray("[0,1]"));
            // Test.Print(solution.SubsetsWithDup, IntArray("[0,1,1]"));
            Test.Print(solution.SubsetsWithDup, IntArray("[0,1,2,2]"));
        }
        
    }
}