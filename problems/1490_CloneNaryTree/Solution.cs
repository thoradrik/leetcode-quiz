namespace Quiz {
    public class Solution {
        
        public Node CloneTree(Node root) {
            if (root == null) {
                return null;
            }
            
            Node clone_node(Node original) {
                var clone = new Node(original.val);

                foreach (var child in original.children) {
                    clone.children.Add(clone_node(child));
                }
                
                return clone;
            }

            return clone_node(root);
        }
        
    }
}