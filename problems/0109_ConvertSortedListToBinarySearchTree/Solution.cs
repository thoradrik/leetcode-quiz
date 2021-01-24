namespace Quiz {
    public class Solution {

        public TreeNode SortedListToBST(int[] nums) {
            ListNode tail = null;
            
            for (int i = nums.Length - 1; i >= 0; i--) {
                tail = new ListNode(nums[i], tail);
            }
            
            return SortedListToBST(tail);
        }

        public TreeNode SortedListToBST(ListNode head) {
            int length = 0;

            ListNode ptr = head;
            while (ptr != null) {
                length++;
                ptr = ptr.next;
            }

            return SortedListToBST(head, length, out ListNode end);
        }

        private TreeNode SortedListToBST(ListNode start, int length, out ListNode end) {
            if (start == null || length <= 0) {
                end = null;
                return null;
            } else if (length == 1) {
                end = start.next;
                return new TreeNode(start.val);
            } else if (length == 2) {
                end = start.next.next;
                return new TreeNode(start.next.val) { left = new TreeNode(start.val) };
            } else {
                int half = length / 2;
                if (length % 2 == 0) {
                    TreeNode left = SortedListToBST(start, half - 1, out ListNode middle);
                    TreeNode right = SortedListToBST(middle.next, half, out end);
                    return new TreeNode(middle.val) {
                        left = left,
                        right = right
                    };
                } else {
                    TreeNode left = SortedListToBST(start, half, out ListNode middle);
                    TreeNode right = SortedListToBST(middle.next, half, out end);
                    return new TreeNode(middle.val) {
                        left = left,
                        right = right
                    };
                }
            }
        }

    }
}