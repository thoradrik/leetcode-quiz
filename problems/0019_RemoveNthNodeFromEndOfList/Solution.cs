namespace Quiz;

public class Solution {

    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode current = head;
        
        while (n > 0) {
            current = current.next;
            n--;
        }
        
        ListNode slow = head;
        ListNode fast = current;
        ListNode prev = null;
        while (fast != null) {
            prev = slow;
            slow = slow.next;
            fast = fast.next;
        }

        if (prev == null) {
            return slow.next;
        } else {
            prev.next = slow.next;
            return head;
        }
    }

    public ListNode RemoveNthFromEnd_SubOptimal_V1(ListNode head, int n) {
        if (head.next == null) {
            return null;
        }

        int count = 0;

        ListNode current = head;
        while (current != null) {
            count++;
            current = current.next;
        }

        int index = count - n;
        
        current = head;
        ListNode prev = null;
        while (current != null && index > 0) {
            prev = current;
            current = current.next;
            index--;
        }

        if (prev == null) {
            return current.next;
        } else {
            prev.next = current.next;
            return head;
        }
    }

}
