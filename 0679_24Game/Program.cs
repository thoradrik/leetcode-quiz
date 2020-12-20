namespace Quiz {
    public class Program : ProgramBase {

        public static void Main(string[] args) {
            Solution solution = new Solution();
            
            Test.Check(solution.JudgePoint24, IntArray("[4, 1, 8, 7]"), true);
            Test.Check(solution.JudgePoint24, IntArray("[1, 2, 1, 2]"), false);
        }
        
    }
}