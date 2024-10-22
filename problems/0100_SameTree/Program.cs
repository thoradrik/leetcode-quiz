using LeetcodeLib;

namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.IsSameTree, TreeHelper.CreateTreeFromBFS("[]"), TreeHelper.CreateTreeFromBFS("[]"), true);
            Test.Check(solution.IsSameTree, TreeHelper.CreateTreeFromBFS("[]"), TreeHelper.CreateTreeFromBFS("[1]"), false);
            Test.Check(solution.IsSameTree, TreeHelper.CreateTreeFromBFS("[1]"), TreeHelper.CreateTreeFromBFS("[]"), false);
            Test.Check(solution.IsSameTree, TreeHelper.CreateTreeFromBFS("[1]"), TreeHelper.CreateTreeFromBFS("[1]"), true);
            Test.Check(solution.IsSameTree, TreeHelper.CreateTreeFromBFS("[1,2,3]"), TreeHelper.CreateTreeFromBFS("[1,2,3]"), true);
            Test.Check(solution.IsSameTree,  TreeHelper.CreateTreeFromBFS("[1,2]"),  TreeHelper.CreateTreeFromBFS("[1,null,2]"), false);
            Test.Check(solution.IsSameTree, TreeHelper.CreateTreeFromBFS("[1,2,3]"), TreeHelper.CreateTreeFromBFS("[1,3,2]"), false);
        }

    }
}
