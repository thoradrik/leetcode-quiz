namespace AddTwoNumbers {
    public class Solution {
        
        public ListNode AddTwoNumbers(ListNode a, ListNode b) {
            return Next(a, b, 0);
        }
        
        private ListNode Next(ListNode a, ListNode b, int carry) {
            if (a == null && b == null) {
                if (carry == 0) {
                    return null;
                } else {
                    return new ListNode(carry);
                }
            } else {
                int sum = (a?.val ?? 0) + (b?.val ?? 0) + carry;
            
                int sum_c = sum / 10;
                int sum_r = sum % 10;

                return new ListNode(sum_r) {
                    next = Next(a?.next, b?.next, sum_c)
                };
            }
        }
        
    }
}