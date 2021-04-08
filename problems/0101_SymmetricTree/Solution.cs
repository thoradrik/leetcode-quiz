using LeetcodeLib;

namespace Quiz {
    public class Solution {
        
        public bool IsSymmetric(TreeNode root) {
            return Check(root.left, root.right);
        }

        private bool Check(TreeNode l_node, TreeNode r_node) {
            if (l_node == null && r_node == null) {
                return true;
            } 
            
            if (l_node != null && r_node != null) {
                if (l_node.val == r_node.val) {
                    return Check(l_node.right, r_node.left) && Check(l_node.left, r_node.right);
                }
            }
            
            return false;
        }
        
    }
}