using System.Text.Json;

namespace Quiz {
    public static class Program {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.SortedSquares, Array("[]"), Array("[]"));
            Test.Check(solution.SortedSquares, Array("[1]"), Array("[1]"));
            Test.Check(solution.SortedSquares, Array("[0,1,2]"), Array("[0,1,4]"));
            Test.Check(solution.SortedSquares, Array("[-2,-1,0]"), Array("[0,1,4]"));
            Test.Check(solution.SortedSquares, Array("[-1,1]"), Array("[1,1]"));
            Test.Check(solution.SortedSquares, Array("[-2,0,2]"), Array("[0,4,4]"));
            Test.Check(solution.SortedSquares, Array("[-4,-1,0,3,10]"), Array("[0,1,9,16,100]"));
            Test.Check(solution.SortedSquares, Array("[-7,-3,2,3,11]"), Array("[4,9,9,49,121]"));
        }

        private static int[] Array(string s) => JsonSerializer.Deserialize<int[]>(s);

    }
}