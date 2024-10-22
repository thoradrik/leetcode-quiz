using LeetcodeLib;

namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.MaxDepth, TreeHelper.CreateTreeFromBFS("[]"), 0);
            Test.Check(solution.MaxDepth, TreeHelper.CreateTreeFromBFS("[1]"), 1);
            Test.Check(solution.MaxDepth, TreeHelper.CreateTreeFromBFS("[1,null,null]"), 1);
            Test.Check(solution.MaxDepth, TreeHelper.CreateTreeFromBFS("[1,1,null]"), 2);
            Test.Check(solution.MaxDepth, TreeHelper.CreateTreeFromBFS("[1,1,1]"), 2);
            Test.Check(solution.MaxDepth, TreeHelper.CreateTreeFromBFS("[1,1,1,1,null,null,null]"), 3);
            Test.Check(solution.MaxDepth, TreeHelper.CreateTreeFromBFS("[1,1,1,null,1,null,null]"), 3);
            Test.Check(solution.MaxDepth, TreeHelper.CreateTreeFromBFS("[1,1,1,null,null,1,null]"), 3);
            Test.Check(solution.MaxDepth, TreeHelper.CreateTreeFromBFS("[1,1,1,null,null,1,1]"), 3);
            Test.Check(solution.MaxDepth, TreeHelper.CreateTreeFromBFS("[1,1,1,null,5,1,1]"), 3);
            Test.Check(solution.MaxDepth, TreeHelper.CreateTreeFromBFS("[3,9,20,null,null,15,7]"), 3);
            Test.Check(solution.MaxDepth, TreeHelper.CreateTreeFromBFS("[1,null,2]"), 2);
            Test.Check(solution.MaxDepth, TreeHelper.CreateTreeFromBFS("[2,null,3,null,4,null,5,null,6]"), 5);
        }

    }
}
