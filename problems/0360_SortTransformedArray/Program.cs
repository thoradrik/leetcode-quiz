namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.SortTransformedArray, IntArray("[-4,-2,2,4]"), 1, 3, 5, IntArray("[3,9,15,33]"));
            Test.Check(solution.SortTransformedArray, IntArray("[-4,-2,2,4]"), -1, 3, 5, IntArray("[-23,-5,1,7]"));
        }

    }
}