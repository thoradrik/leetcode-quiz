using LeetcodeLib;

namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.IsBalanced, TreeHelper.CreateTreeFromBFS("[]"), true);
            Test.Check(solution.IsBalanced, TreeHelper.CreateTreeFromBFS("[1]"), true);
            Test.Check(solution.IsBalanced, TreeHelper.CreateTreeFromBFS("[1,2,2]"), true);
            Test.Check(solution.IsBalanced, TreeHelper.CreateTreeFromBFS("[1,2,2,3,null,3,3]"), true);
            Test.Check(solution.IsBalanced, TreeHelper.CreateTreeFromBFS("[1,2,2,3,null,null,null]"), true);
            Test.Check(solution.IsBalanced, TreeHelper.CreateTreeFromBFS("[1,2,2,3,null,null,null,4,4]"), false);
            Test.Check(solution.IsBalanced, TreeHelper.CreateTreeFromBFS("[3,9,20,null,null,15,7]"), true);
            Test.Check(solution.IsBalanced, TreeHelper.CreateTreeFromBFS("[1,2,2,3,3,null,null,4,4]"), false);
        }

    }
}