namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.DiStringMatch, "IDID", IntArray("[0,4,1,3,2]"));
            Test.Check(solution.DiStringMatch, "III", IntArray("[0,1,2,3]"));
            Test.Check(solution.DiStringMatch, "DDD", IntArray("[3,2,1,0]"));
            Test.Check(solution.DiStringMatch, "DDI", IntArray("[3,2,0,1]"));
        }

    }
}