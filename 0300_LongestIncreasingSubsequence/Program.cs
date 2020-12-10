using System.Text.Json;

namespace Quiz {
    public static class Program {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.LengthOfLIS, Array("[]"), 0);
            Test.Check(solution.LengthOfLIS, Array("[1]"), 1);
            Test.Check(solution.LengthOfLIS, Array("[1,2]"), 2);
            Test.Check(solution.LengthOfLIS, Array("[2,1]"), 1);
            Test.Check(solution.LengthOfLIS, Array("[10,9,2,5,3,7,101,18]"), 4);
            Test.Check(solution.LengthOfLIS, Array("[0,1,0,3,2,3]"), 4);
            Test.Check(solution.LengthOfLIS, Array("[7,7,7,7,7,7,7]"), 1);
        }

        private static int[] Array(string s) => JsonSerializer.Deserialize<int[]>(s);

    }
}