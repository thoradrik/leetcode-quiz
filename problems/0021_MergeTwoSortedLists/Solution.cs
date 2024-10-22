namespace Quiz;

public class Solution {

    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        var a = l1;
        var b = l2;

        var r = new ListNode();
        var i = r;

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
