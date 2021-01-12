﻿namespace Quiz {
    public class Solution {
        
        public bool IsSameTree(TreeNode p, TreeNode q) {
            if (p == null) {
                return q == null;
            }  

            if (q == null) {
                return p == null;
            }
            
            if (p.val != q.val) {
                return false;
            } else {
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }
        }
        
    }
}