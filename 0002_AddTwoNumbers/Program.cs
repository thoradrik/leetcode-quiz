using System;

namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            ListNode a = new ListNode(9) {
                next = new ListNode(9) {
                    next = new ListNode(9) { }   
                }
            };
            
            ListNode b = new ListNode(5) {
                next = new ListNode(6) {
                    next = new ListNode(9) {
                        next = new ListNode(9) { }
                    }   
                }
            };
            
            Solution solution = new Solution();
            ListNode c = solution.AddTwoNumbers(a, b);
            
            Print(a);
            Print(b);
            Print(c);
        }

        private static void Print(ListNode a) {
            ListNode node = a;
            while (node != null) {
                Console.Write(node.val);
                
                node = node.next;
                
                if (node != null) {
                    Console.Write(" --> ");    
                }
            }
            
            Console.WriteLine();
        }
    }
}