namespace Quiz;

public class Solution {

    public ListNode DetectCycle(ListNode head) {
        if (head == null) {
            return null;
        }

        var turtle = head;
        var hear = head;

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

        var a = head;
        var b = turtle;

        while (a != b) {
            a = a.next;
            b = b.next;
        }

        return a;
    }

}
