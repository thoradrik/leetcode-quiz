namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            Solution solution = new Solution();

            TreeNode p_0 = (TreeNode)null;
            TreeNode q_0 = (TreeNode)null;

            Test.Check(solution.IsSameTree, p_0, q_0, true);

            TreeNode p_1 = new TreeNode(1);
            TreeNode q_1 = new TreeNode(1);
            
            Test.Check(solution.IsSameTree, p_0, q_1, false);
            Test.Check(solution.IsSameTree, p_1, q_0, false);
            Test.Check(solution.IsSameTree, p_1, q_1, true);

            TreeNode p_123 = new TreeNode(1, new TreeNode(2), new TreeNode(3));           
            TreeNode q_123 = new TreeNode(1, new TreeNode(2), new TreeNode(3));

            Test.Check(solution.IsSameTree, p_123, q_123, true);
            
            TreeNode p_12 = new TreeNode(1, new TreeNode(2), null);           
            TreeNode q_12 = new TreeNode(1, null, new TreeNode(1));

            Test.Check(solution.IsSameTree, p_12, q_12, false);

            TreeNode p_112 = new TreeNode(1, new TreeNode(1), new TreeNode(2));           
            TreeNode q_121 = new TreeNode(1, new TreeNode(2), new TreeNode(1));

            Test.Check(solution.IsSameTree, p_112, q_121, false);
        }

    }
}