namespace Quiz {
    public class Solution {
        
        public Node CloneTree(Node root) {
            if (root == null) {
                return null;
            }
            
            Node clone_node(Node original) {
                Node clone = new Node(original.val);

                foreach (Node child in original.children) {
                    clone.children.Add(clone_node(child));
                }
                
                return clone;
            }

            return clone_node(root);
        }
        
    }
}