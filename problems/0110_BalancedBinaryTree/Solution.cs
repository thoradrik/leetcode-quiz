using System;
using LeetcodeLib;

namespace Quiz {
    public class Solution {
        
        public bool IsBalanced(TreeNode root) {
            return IsBalanced(root, out _);
        }
        
        private bool IsBalanced(TreeNode root, out int height) {
            if (root == null) {
                height = 0;
                return true;
            } else {
                bool l_balanced = IsBalanced(root.left, out int l_height);
                if (!l_balanced) {
                    height = 0;
                    return false;
                }
                
                bool r_balanced = IsBalanced(root.right, out int r_height);
                if (!r_balanced) {
                    height = 0;
                    return false;
                }

                int max = Math.Max(l_height, r_height);
                int min = Math.Min(l_height, r_height);

                height = max + 1;
                
                return max - min <= 1;
            }
        }
        
    }
}