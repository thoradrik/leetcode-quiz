namespace Quiz {
    public class Solution {

        public bool HasCycle(ListNode head) {
            if (head == null) {
                return false;
            }
            
            ListNode turtle = head;
            ListNode hear = head;

            while (true) {
                turtle = turtle.next;
                if (turtle == null) {
                    return false;
                }

                hear = hear.next?.next;
                if (hear == null) {
                    return false;
                }
                
                if (turtle == hear) {
                    return true;
                }
            }
        }

    }
}