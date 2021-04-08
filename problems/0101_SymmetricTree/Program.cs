using LeetcodeLib;

namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.IsSymmetric, TreeHelper.CreateTreeFromBFS("[1]"), true);
            Test.Check(solution.IsSymmetric, TreeHelper.CreateTreeFromBFS("[1,2,null]"), false);
            Test.Check(solution.IsSymmetric, TreeHelper.CreateTreeFromBFS("[1,null,2]"), false);
            Test.Check(solution.IsSymmetric, TreeHelper.CreateTreeFromBFS("[1,2,1]"), false);
            Test.Check(solution.IsSymmetric, TreeHelper.CreateTreeFromBFS("[1,2,2]"), true);
            Test.Check(solution.IsSymmetric, TreeHelper.CreateTreeFromBFS("[1,2,2,null,1,null,null]"), false);
            Test.Check(solution.IsSymmetric, TreeHelper.CreateTreeFromBFS("[1,2,2,null,1,null,1]"), false);
            Test.Check(solution.IsSymmetric, TreeHelper.CreateTreeFromBFS("[1,2,2,null,1,1,null]"), true);
            Test.Check(solution.IsSymmetric, TreeHelper.CreateTreeFromBFS("[1,2,2,null,1,1,2]"), false);
            Test.Check(solution.IsSymmetric, TreeHelper.CreateTreeFromBFS("[1,2,2,3,1,1,2]"), false);
            Test.Check(solution.IsSymmetric, TreeHelper.CreateTreeFromBFS("[1,2,2,3,1,1,3]"), true);
            Test.Check(solution.IsSymmetric, TreeHelper.CreateTreeFromBFS("[1,2,2,3,1,1,3,4,4,4,4,4,4,4,4]"), true);
            Test.Check(solution.IsSymmetric, TreeHelper.CreateTreeFromBFS("[1,2,2,3,1,1,3,4,5,4,4,4,4,5,4]"), true);
            Test.Check(solution.IsSymmetric, TreeHelper.CreateTreeFromBFS("[1,2,2,3,1,1,3,4,5,4,6,7,4,5,4]"), false);
            Test.Check(solution.IsSymmetric, TreeHelper.CreateTreeFromBFS("[1,2,2,3,1,1,3,4,5,4,6,6,4,5,4]"), true);
        }

    }
}