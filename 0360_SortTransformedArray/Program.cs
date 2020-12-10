using System.Text.Json;

namespace Quiz {
    public static class Program {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.SortTransformedArray, Array("[-4,-2,2,4]"), 1, 3, 5, Array("[3,9,15,33]"));
            Test.Check(solution.SortTransformedArray, Array("[-4,-2,2,4]"), -1, 3, 5, Array("[-23,-5,1,7]"));
        }

        private static int[] Array(string s) => JsonSerializer.Deserialize<int[]>(s);

    }
}