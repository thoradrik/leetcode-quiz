namespace Quiz;

public class Solution {

    public bool IsPalindrome(ListNode head) {
        if (head == null) return true;

        ListNode tail = null;

        var current_slow = head;
        var current_fast = head;
        while (current_fast != null && current_fast.next != null) {
            current_fast = current_fast.next.next;

            var next = current_slow.next;
            current_slow.next = tail;

            tail = current_slow;
            current_slow = next;
        }

        var current_s = current_fast != null ? current_slow.next : current_slow;
        var current_f = tail;

        while (current_s != null) {
            if (current_f.val != current_s.val) {
                return false;
            }

            current_s = current_s.next;
            current_f = current_f.next;
        }

        return true;
    }

    public bool IsPalindrome_SubOptimal_V2(ListNode head) {
        if (head == null) return true;

        ListNode tail = null;

        var current_slow = head;
        var current_fast = head;
        while (current_fast != null && current_fast.next != null) {
            tail = new ListNode(current_slow.val, tail);

            current_slow = current_slow.next;
            current_fast = current_fast.next.next;
        }

        var current_s = current_fast != null ? current_slow.next : current_slow;
        var current_f = tail;

        while (current_s != null) {
            if (current_f.val != current_s.val) {
                return false;
            }

            current_s = current_s.next;
            current_f = current_f.next;
        }

        return true;
    }

    public bool IsPalindrome_SubOptimal_V1(ListNode head) {
        if (head == null) return true;

        ListNode tail = null;

        var current = head;
        while (current != null) {
            tail = new ListNode(current.val, tail);

            current = current.next;
        }

        var current_s = head;
        var current_f = tail;

        while (current_s != null) {
            if (current_f.val != current_s.val) {
                return false;
            }

            current_s = current_s.next;
            current_f = current_f.next;
        }

        return true;
    }

}
