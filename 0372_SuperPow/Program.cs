using System.Text.Json;

namespace Quiz {
    public static class Program {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.SuperPow, 0, Array("[0]"), 1);
            Test.Check(solution.SuperPow, 0, Array("[1]"), 0);
            Test.Check(solution.SuperPow, 0, Array("[2]"), 0);
            Test.Check(solution.SuperPow, 0, Array("[3]"), 0);
            Test.Check(solution.SuperPow, 1, Array("[0]"), 1);
            Test.Check(solution.SuperPow, 1, Array("[1]"), 1);
            Test.Check(solution.SuperPow, 1, Array("[3]"), 1);
            Test.Check(solution.SuperPow, 1, Array("[3]"), 1);
            Test.Check(solution.SuperPow, 2, Array("[0]"), 1);
            Test.Check(solution.SuperPow, 2, Array("[1]"), 2);
            Test.Check(solution.SuperPow, 2, Array("[2]"), 4);
            Test.Check(solution.SuperPow, 2, Array("[3]"), 8);
            Test.Check(solution.SuperPow, 2, Array("[1,0]"), 1024);
            Test.Check(solution.SuperPow, 2, Array("[1,1]"), 711);
            Test.Check(solution.SuperPow, 2, Array("[1,0,1]"), 1019);
            Test.Check(solution.SuperPow, 1, Array("[4,3,3,8,5,2]"), 1);
            Test.Check(solution.SuperPow, 2147483647, Array("[2,0,0]"), 1198);
        }

        private static int[] Array(string s) => JsonSerializer.Deserialize<int[]>(s);

    }
}