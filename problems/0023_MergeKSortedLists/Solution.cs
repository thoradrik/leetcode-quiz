namespace Quiz;

public class Solution {

    /*
    public ListNode MergeKLists(ListNode[] lists) {
        ListNode[] p = new ListNode[lists.Length];
        int p_length = 0;

        for (int j = 0; j < lists.Length; j++) {
            ListNode list_node = lists[j];
            if (list_node != null) {
                p[p_length] = list_node;
                p_length++;
            }
        }

        ListNode r = new ListNode();
        ListNode i = r;

        while (true) {
            if (p_length <= 0) {
                break;
            }

            if (p_length == 1) {
                i.next = p[0];
            }

            int min = p[0].val;
            int min_pi = 0;

            for (int pi = 1; pi < p_length; pi++) {
                if (p[pi].val < min) {
                    min = p[pi].val;
                    min_pi = pi;
                }
            }

            ListNode pp = p[min_pi];
            i.next = pp;
            i = pp;

            if (pp.next != null) {
                p[min_pi] = pp.next;
            } else {
                for (int pi = min_pi + 1; pi < p_length; pi++) {
                    p[pi - 1] = p[pi];
                }

                p_length--;
            }
        }

        return r.next;
    }
    */
        
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length <= 0) {
            return null;
        } else {
            return MergeKLists(lists, lists.Length);
        }
    }

    private ListNode MergeKLists(ListNode[] lists, int length) {
        if (length == 1) {
            return lists[0];
        } else if (length % 2 == 0) {
            for (int i = 0; i < (length >> 1); i++) {
                lists[i] = MergeTwoLists(lists[(i << 1)], lists[(i << 1) + 1]);
            }
                
            return MergeKLists(lists, length >> 1);
        } else {
            return MergeTwoLists(lists[length - 1], MergeKLists(lists, length - 1));
        }
    }

    private ListNode MergeTwoLists(ListNode a, ListNode b) {
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