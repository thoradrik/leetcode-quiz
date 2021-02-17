using AlgorithmLib;

namespace LeetcodeLib {
    public class TreeNode : IBinaryTreeNode<int> {

        // ReSharper disable InconsistentNaming
        public int val;

        public TreeNode left;

        public TreeNode right;
        // ReSharper restore InconsistentNaming

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        int IBinaryTreeNode<int>.Value => val;

        IBinaryTreeNode<int> IBinaryTreeNode<int>.Left => left;

        IBinaryTreeNode<int> IBinaryTreeNode<int>.Right => right;

    }
}