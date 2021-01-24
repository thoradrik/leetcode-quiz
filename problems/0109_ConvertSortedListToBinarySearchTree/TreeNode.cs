namespace Quiz {
    public class TreeNode : IIntTreeNode {

        public int val;

        public TreeNode left;

        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        int IIntTreeNode.Value => val;

        IIntTreeNode IIntTreeNode.Left => left;

        IIntTreeNode IIntTreeNode.Right => right;

    }
}