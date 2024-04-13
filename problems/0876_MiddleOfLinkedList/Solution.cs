namespace Quiz;

public class Solution {

    public ListNode MiddleNode(ListNode head) {
        ListNode current = head;
        ListNode fast = head;

        while (fast != null && fast.next != null) {
            current = current.next;
            fast = fast.next.next;
        }

        return current;
    }

}