namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            // Test.Print(solution.SortedListToBST, IntArray("[]"));
            // Test.Print(solution.SortedListToBST, IntArray("[0]"));
            Test.Print(solution.SortedListToBST, IntArray("[0,1]"));
            Test.Print(solution.SortedListToBST, IntArray("[-1,0,1]"));
            Test.Print(solution.SortedListToBST, IntArray("[-1,0,1,2]"));
            Test.Print(solution.SortedListToBST, IntArray("[-2,-1,0,1,2]"));
            Test.Print(solution.SortedListToBST, IntArray("[-3,-2,-1,0,1,2]"));
            Test.Print(solution.SortedListToBST, IntArray("[-3,-2,-1,0,1,2,3]"));
        }

    }
}