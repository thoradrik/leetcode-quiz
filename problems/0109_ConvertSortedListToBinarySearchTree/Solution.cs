using LeetcodeLib;

namespace Quiz;

public class Solution {

    public TreeNode SortedListToBST(ListNode head) {
        var length = 0;

        var ptr = head;
        while (ptr != null) {
            length++;
            ptr = ptr.next;
        }

        return SortedListToBST(head, length, out var end);
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
                var left = SortedListToBST(start, half - 1, out var middle);
                var right = SortedListToBST(middle.next, half, out end);
                return new TreeNode(middle.val) {
                    left = left,
                    right = right
                };
            } else {
                var left = SortedListToBST(start, half, out var middle);
                var right = SortedListToBST(middle.next, half, out end);
                return new TreeNode(middle.val) {
                    left = left,
                    right = right
                };
            }
        }
    }

}
