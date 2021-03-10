using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public Node CloneGraph(Node node) {
            if (node == null) {
                return null;
            }
            
            Dictionary<int, Node> map = new Dictionary<int, Node>();

            Node clone_node(Node original) {
                if (map.TryGetValue(original.val, out Node clone)) {
                    return clone;
                } else {
                    clone = new Node(original.val);
                    map.Add(clone.val, clone);

                    foreach (Node neighbor in original.neighbors) {
                        clone.neighbors.Add(clone_node(neighbor));
                    }

                    return clone;
                }
            }

            return clone_node(node);
        }
        
    }
}