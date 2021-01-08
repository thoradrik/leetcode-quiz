namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.MakeGood, "leEeetcode", "leetcode");
            Test.Check(solution.MakeGood, "abBAcC", "");
            Test.Check(solution.MakeGood, "dabBAcCD", "");
            Test.Check(solution.MakeGood, "eEdabBAcCD", "");
            Test.Check(solution.MakeGood, "FeEdabBAcCDf", "");
            Test.Check(solution.MakeGood, "FeEdabBAczZCDf", "");
            Test.Check(solution.MakeGood, "FeEdabBAczZCDfQq1", "1");
            Test.Check(solution.MakeGood, "s", "s");
        }

    }
}