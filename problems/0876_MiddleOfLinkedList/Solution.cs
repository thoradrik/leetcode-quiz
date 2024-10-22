namespace Quiz;

public class Solution {

    public ListNode MiddleNode(ListNode head) {
        var current = head;
        var fast = head;

        while (fast != null && fast.next != null) {
            current = current.next;
            fast = fast.next.next;
        }

        return current;
    }

}
