using System.Text.Json;

namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            ListNode[] nodes;

            Test.Check(solution.DetectCycle, (ListNode)null, (ListNode)null);
            Test.Check(solution.DetectCycle, LinkedList("[1]", 0, out nodes), nodes[0]);
            Test.Check(solution.DetectCycle, LinkedList("[1]", -1, out nodes), null);
            Test.Check(solution.DetectCycle, LinkedList("[1,2]", 0, out nodes), nodes[0]);
            Test.Check(solution.DetectCycle, LinkedList("[1,2]", 1, out nodes), nodes[1]);
            Test.Check(solution.DetectCycle, LinkedList("[1,2]", -1, out nodes), null);
            Test.Check(solution.DetectCycle, LinkedList("[3,2,0,-4]", 0, out nodes), nodes[0]);
            Test.Check(solution.DetectCycle, LinkedList("[3,2,0,-4]", 1, out nodes), nodes[1]);
            Test.Check(solution.DetectCycle, LinkedList("[3,2,0,-4]", 2, out nodes), nodes[2]);
            Test.Check(solution.DetectCycle, LinkedList("[3,2,0,-4]", 3, out nodes), nodes[3]);
            Test.Check(solution.DetectCycle, LinkedList("[3,2,0,-4]", -1, out nodes), null);
        }

        private static ListNode LinkedList(string s, int cycle, out ListNode[] nodes) {
            int[] n = JsonSerializer.Deserialize<int[]>(s);
            nodes = new ListNode[n.Length];
            
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

                nodes[i] = node;
            }

            return node;
        }        
    }
}