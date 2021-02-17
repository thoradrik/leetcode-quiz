using System.Collections.Generic;
using LeetcodeLib;

namespace Quiz {
    public class Solution {
        
        public IList<int> RightSideView(TreeNode root) {
            List<int> list = new List<int>();
            
            void backtrace(TreeNode node, int level) {
                if (list.Count <= level) {
                    list.Add(node.val);
                }

                if (node.right != null) {
                    backtrace(node.right, level + 1);
                }
                if (node.left != null) {
                    backtrace(node.left, level + 1);
                }
            }

            if (root != null) {
                backtrace(root, 0);
            }

            return list;
        }
        
    }
}