using LeetcodeLib;

namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.MinDepth, TreeHelper.CreateTreeFromBFS("[]"), 0);
            Test.Check(solution.MinDepth, TreeHelper.CreateTreeFromBFS("[1]"), 1);
            Test.Check(solution.MinDepth, TreeHelper.CreateTreeFromBFS("[1,null,null]"), 1);
            Test.Check(solution.MinDepth, TreeHelper.CreateTreeFromBFS("[1,1,null]"), 2);
            Test.Check(solution.MinDepth, TreeHelper.CreateTreeFromBFS("[1,1,1]"), 2);
            Test.Check(solution.MinDepth, TreeHelper.CreateTreeFromBFS("[1,1,1,1,null,null,null]"), 2);
            Test.Check(solution.MinDepth, TreeHelper.CreateTreeFromBFS("[1,1,1,null,1,null,null]"), 2);
            Test.Check(solution.MinDepth, TreeHelper.CreateTreeFromBFS("[1,1,1,null,null,1,null]"), 2);
            Test.Check(solution.MinDepth, TreeHelper.CreateTreeFromBFS("[1,1,1,null,null,1,1]"), 2);
            Test.Check(solution.MinDepth, TreeHelper.CreateTreeFromBFS("[1,1,1,null,5,1,1]"), 3);
            Test.Check(solution.MinDepth, TreeHelper.CreateTreeFromBFS("[3,9,20,null,null,15,7]"), 2);
            Test.Check(solution.MinDepth, TreeHelper.CreateTreeFromBFS("[2,null,3,null,4,null,5,null,6]"), 5);
        }

    }
}