namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Print(solution.Subsets, IntArray("[]"));
            Test.Print(solution.Subsets, IntArray("[0]"));
            Test.Print(solution.Subsets, IntArray("[0,1]"));
            Test.Print(solution.Subsets, IntArray("[0,1,-1]"));
            Test.Print(solution.Subsets, IntArray("[1,2,3,4]"));
            Test.Print(solution.Subsets, IntArray("[1,2,3,4,5]"));
        }

    }
}