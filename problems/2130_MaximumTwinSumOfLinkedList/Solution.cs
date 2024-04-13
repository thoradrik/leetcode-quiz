namespace Quiz;

public class Solution {

    public int PairSum(ListNode head) {
        ListNode half = head;
        
        ListNode tail = null;
        ListNode current = head;
        while (half != null && half.next != null) {
            half = half.next.next;
            
            ListNode next = current.next;
            current.next = tail;
                
            tail = current;
            current = next;
        }

        ListNode current_f = tail;
        ListNode current_s = current;

        int max = current_f.val + current_s.val;

        while (current_f != null) {
            max = Math.Max(current_f.val + current_s.val, max);
            
            current_f = current_f.next;
            current_s = current_s.next;
        }

        return max;
    }

    public int PairSum_SubOptimal_V1(ListNode head) {
        ListNode half = head;
        
        ListNode tail = null;
        ListNode current = head;
        while (half != null && half.next != null) {
            tail = new ListNode(current.val, tail);

            current = current.next;
            half = half.next.next;
        }


        ListNode current_f = tail;
        ListNode current_s = current;

        int max = current_f.val + current_s.val;

        while (current_f != null) {
            max = Math.Max(current_f.val + current_s.val, max);
            
            current_f = current_f.next;
            current_s = current_s.next;
        }

        return max;
    }

}
