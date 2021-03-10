using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public Node CopyRandomList(Node head) {
            Dictionary<Node, Node> map = new Dictionary<Node, Node>();

            Node clone_node(Node original) {
                if (original == null) {
                    return null;
                }
                
                if (map.TryGetValue(original, out Node clone)) {
                    return clone;
                } else {
                    clone = new Node(original.val);
                    map.Add(original, clone);

                    clone.next = clone_node(original.next);
                    clone.random = clone_node(original.random);

                    return clone;
                }
            }

            return clone_node(head);
        }

    }
}