using System.Text.Json;

namespace Quiz {
    public class Program {

        public static void Main(string[] args) {
            Solution solution = new Solution();
            
            Test.Check(solution.JudgePoint24, Array("[4, 1, 8, 7]"), true);
            Test.Check(solution.JudgePoint24, Array("[1, 2, 1, 2]"), false);
        }

        private static int[] Array(string s) => JsonSerializer.Deserialize<int[]>(s);
        
    }
}