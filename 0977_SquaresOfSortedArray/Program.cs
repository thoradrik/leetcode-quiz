namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.SortedSquares, IntArray("[]"), IntArray("[]"));
            Test.Check(solution.SortedSquares, IntArray("[1]"), IntArray("[1]"));
            Test.Check(solution.SortedSquares, IntArray("[0,1,2]"), IntArray("[0,1,4]"));
            Test.Check(solution.SortedSquares, IntArray("[-2,-1,0]"), IntArray("[0,1,4]"));
            Test.Check(solution.SortedSquares, IntArray("[-1,1]"), IntArray("[1,1]"));
            Test.Check(solution.SortedSquares, IntArray("[-2,0,2]"), IntArray("[0,4,4]"));
            Test.Check(solution.SortedSquares, IntArray("[-4,-1,0,3,10]"), IntArray("[0,1,9,16,100]"));
            Test.Check(solution.SortedSquares, IntArray("[-7,-3,2,3,11]"), IntArray("[4,9,9,49,121]"));
        }

    }
}