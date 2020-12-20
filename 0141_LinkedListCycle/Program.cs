using System.Text.Json;

namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.HasCycle, (ListNode)null, false);
            Test.Check(solution.HasCycle, LinkedList("[1]", 0), true);
            Test.Check(solution.HasCycle, LinkedList("[1]", -1), false);
            Test.Check(solution.HasCycle, LinkedList("[1,2]", 0), true);
            Test.Check(solution.HasCycle, LinkedList("[1,2]", 1), true);
            Test.Check(solution.HasCycle, LinkedList("[1,2]", -1), false);
            Test.Check(solution.HasCycle, LinkedList("[3,2,0,-4]", 0), true);
            Test.Check(solution.HasCycle, LinkedList("[3,2,0,-4]", 1), true);
            Test.Check(solution.HasCycle, LinkedList("[3,2,0,-4]", 2), true);
            Test.Check(solution.HasCycle, LinkedList("[3,2,0,-4]", 3), true);
            Test.Check(solution.HasCycle, LinkedList("[3,2,0,-4]", -1), false);
        }

        private static ListNode LinkedList(string s, int cycle) {
            int[] n = JsonSerializer.Deserialize<int[]>(s);
            
            ListNode node = null;
            ListNode last = null;

            for (int i = n.Length - 1; i >= 0; i--) {
                node = new ListNode(n[i]) {
                    next = node
                };

                if (last == null) {
                    last = node;
                }

                if (i == cycle) {
                    last.next = node;
                }                
            }

            return node;
        }        
    }
}