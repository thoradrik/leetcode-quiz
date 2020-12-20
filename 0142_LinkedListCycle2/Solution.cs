namespace Quiz {
    public class Solution {

        public ListNode DetectCycle(ListNode head) {
            if (head == null) {
                return null;
            }

            ListNode turtle = head;
            ListNode hear = head;

            while (true) {
                turtle = turtle.next;
                if (turtle == null) {
                    return null;
                }

                hear = hear.next?.next;
                if (hear == null) {
                    return null;
                }

                if (turtle == hear) {
                    break;
                }
            }
            
            ListNode a = head;
            ListNode b = turtle;

            while (a != b) {
                a = a.next;
                b = b.next;
            }

            return a;
        }

    }
}