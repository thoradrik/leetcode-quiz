namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.IndexPairs, "thestoryofleetcodeandme", StringArray("[\"story\",\"fleet\",\"leetcode\"]"), Int2Array("[[3,7],[9,13],[10,17]]"));
            Test.Check(solution.IndexPairs, "ababa", StringArray("[\"aba\",\"ab\"]"), Int2Array("[[0,1],[0,2],[2,3],[2,4]]"));
        }

    }
}
