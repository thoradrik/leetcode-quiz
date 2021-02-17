using System.Collections.Generic;
using System.Text.Json;

namespace LeetcodeLib {
    public static class TreeHelper {

        public static TreeNode CreateTreeFromBFS(string bfs) => CreateTreeFromBFS(JsonSerializer.Deserialize<int?[]>(bfs));

        public static TreeNode CreateTreeFromBFS(IList<int?> bfs) {
            if (bfs.Count < 1) {
                return null;
            } 
            
            TreeNode root = new TreeNode();

            root.val = bfs[0].Value;

            Queue<TreeNode> next = new Queue<TreeNode>();

            next.Enqueue(root);

            int ptr = 1;
            
            do {
                Queue<TreeNode> prev = next;

                next = new Queue<TreeNode>();
                
                while (prev.TryDequeue(out TreeNode parent)) {
                    if (ptr < bfs.Count) {
                        int? left_value = bfs[ptr];

                        if (left_value != null) {
                            TreeNode left = new TreeNode(left_value.Value);
                            parent.left = left;
                            next.Enqueue(left);
                        }

                        ptr++;
                    }
                    if (ptr < bfs.Count) {
                        int? right_value = bfs[ptr];
                        if (right_value != null) {
                            TreeNode right = new TreeNode(right_value.Value);
                            parent.right = right;
                            next.Enqueue(right);
                        }

                        ptr++;
                    }
                }
            } while (next.Count > 0);

            return root;
        }

    }
}