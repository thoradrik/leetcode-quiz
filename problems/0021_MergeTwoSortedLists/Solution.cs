namespace Quiz;

public class Solution {

    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode a = l1;
        ListNode b = l2;

        ListNode r = new ListNode();
        ListNode i = r;

        while (a != null || b != null) {
            if (a == null) {
                i.next = b;
                break;
            } else if (b == null) {
                i.next = a;
                break;
            } else {
                if (a.val < b.val) {
                    i.next = a;
                    i = a;
                    a = a.next;
                } else {
                    i.next = b;
                    i = b;
                    b = b.next;
                }
            }
        }

        return r.next;
    }

}