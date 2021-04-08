using System;
using LeetcodeLib;

namespace Quiz {
    public class Solution {
        
        public int MinDepth(TreeNode root) {
            if (root == null) {
                return 0;
            } else if (root.left == null) {
                return MinDepth(root.right) + 1;
            } else if (root.right == null) {
                return MinDepth(root.left) + 1;
            } else {
                return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
            }
        }
        
    }
}