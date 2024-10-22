using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public Node CloneGraph(Node node) {
            if (node == null) {
                return null;
            }

            var map = new Dictionary<int, Node>();

            Node clone_node(Node original) {
                if (map.TryGetValue(original.val, out var clone)) {
                    return clone;
                } else {
                    clone = new Node(original.val);
                    map.Add(clone.val, clone);

                    foreach (var neighbor in original.neighbors) {
                        clone.neighbors.Add(clone_node(neighbor));
                    }

                    return clone;
                }
            }

            return clone_node(node);
        }

    }
}
