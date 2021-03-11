using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public int[] ReverseList(int[] arr) {
            ListNode node = null;

            for (int index = arr.Length - 1; index >= 0; index--) {
                node = new ListNode(arr[index], node);
            }

            node = ReverseList(node);

            List<int> list = new List<int>();
            
            while (node != null) {
                list.Add(node.val);
                
                node = node.next;
            }

            return list.ToArray();
        }

        public ListNode ReverseList(ListNode head) {
            ListNode prev = null;
            ListNode current = head;

            while (current != null) {
                ListNode next = current.next;
                current.next = prev;
                
                prev = current;
                current = next;
            }

            return prev;
        }

    }
}