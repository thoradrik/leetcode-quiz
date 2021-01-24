namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Print(solution.SortedArrayToBST, IntArray("[]"));
            Test.Print(solution.SortedArrayToBST, IntArray("[1]"));
            Test.Print(solution.SortedArrayToBST, IntArray("[0,1]"));
            Test.Print(solution.SortedArrayToBST, IntArray("[-1,0,1]"));
            Test.Print(solution.SortedArrayToBST, IntArray("[-2,-1,0,1,2]"));
            Test.Print(solution.SortedArrayToBST, IntArray("[-2,-1,0,1,2,3]"));
            Test.Print(solution.SortedArrayToBST, IntArray("[-3,-2,-1,0,1,2,3]"));
            Test.Print(solution.SortedArrayToBST, IntArray("[-3,-2,-1,0,1,2,3,6]"));
            Test.Print(solution.SortedArrayToBST, IntArray("[-3,-2,-1,0,1,2,3,6,7]"));
            Test.Print(solution.SortedArrayToBST, IntArray("[-3,-2,-1,0,1,2,3,6,7,10]"));
        }

    }
}