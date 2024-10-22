using LeetcodeLib;

namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.RightSideView, TreeHelper.CreateTreeFromBFS("[]"), IntArray("[]"));
            Test.Check(solution.RightSideView, TreeHelper.CreateTreeFromBFS("[1]"), IntArray("[1]"));
            Test.Check(solution.RightSideView, TreeHelper.CreateTreeFromBFS("[1,2]"), IntArray("[1,2]"));
            Test.Check(solution.RightSideView, TreeHelper.CreateTreeFromBFS("[1,null,3]"), IntArray("[1,3]"));
            Test.Check(solution.RightSideView, TreeHelper.CreateTreeFromBFS("[1,2,3]"), IntArray("[1,3]"));
            Test.Check(solution.RightSideView, TreeHelper.CreateTreeFromBFS("[1,2,3,4,null]"), IntArray("[1,3,4]"));
            Test.Check(solution.RightSideView, TreeHelper.CreateTreeFromBFS("[1,2,3,4,5]"), IntArray("[1,3,5]"));
            Test.Check(solution.RightSideView, TreeHelper.CreateTreeFromBFS("[1,2,3,4,5,6]"), IntArray("[1,3,6]"));
            Test.Check(solution.RightSideView, TreeHelper.CreateTreeFromBFS("[1,2,3,4,5,6,7]"), IntArray("[1,3,7]"));
        }

    }
}
