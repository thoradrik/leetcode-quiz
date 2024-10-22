namespace Quiz;

public class Solution {

    public ListNode DeleteMiddle(ListNode head) {
        if (head.next == null) {
            return null;
        }
        
        var current = head;
        var fast = head;

        ListNode prev = null;
        
        while (fast != null && fast.next != null) {
            prev = current;
            current = current.next;
            fast = fast.next.next;
        }

        prev.next = current.next;
        
        return head;
    }

}