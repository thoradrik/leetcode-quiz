using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public NodeCopy CopyRandomBinaryTree(Node root) {
            Dictionary<Node, NodeCopy> map = new Dictionary<Node, NodeCopy>();

            NodeCopy clone_node(Node original) {
                if (original == null) {
                    return null;
                }
                
                if (map.TryGetValue(original, out NodeCopy clone)) {
                    return clone;
                } else {
                    clone = new NodeCopy(original.val);
                    map.Add(original, clone);

                    clone.left = clone_node(original.left);
                    clone.right = clone_node(original.right);
                    clone.random = clone_node(original.random);

                    return clone;
                }
            }

            return clone_node(root);
        }
        
    }
}