namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            TreeNode root;
            
            root = null;
            Test.Check(solution.RightSideView, root, IntArray("[]"));

            root = new TreeNode(1);
            Test.Check(solution.RightSideView, root, IntArray("[1]"));

            root = new TreeNode(
                1,
                new TreeNode(2),
                null
            );
            Test.Check(solution.RightSideView, root, IntArray("[1,2]"));

            root = new TreeNode(
                1,
                new TreeNode(2),
                new TreeNode(3)
            );
            Test.Check(solution.RightSideView, root, IntArray("[1,3]"));

            root = new TreeNode(
                1,
                new TreeNode(
                    2,
                    new TreeNode(4)
                ),
                new TreeNode(3)
            );
            Test.Check(solution.RightSideView, root, IntArray("[1,3,4]"));

            root = new TreeNode(
                1,
                new TreeNode(
                    2,
                    new TreeNode(4),
                    new TreeNode(5)
                ),
                new TreeNode(
                    3,
                    new TreeNode(6),
                    null
                )
            );
            Test.Check(solution.RightSideView, root, IntArray("[1,3,6]"));

            root = new TreeNode(
                1,
                new TreeNode(
                    2,
                    new TreeNode(4),
                    new TreeNode(5)
                ),
                new TreeNode(
                    3,
                    new TreeNode(6),
                    new TreeNode(7)
                )
            );
            Test.Check(solution.RightSideView, root, IntArray("[1,3,7]"));
        }

    }
}