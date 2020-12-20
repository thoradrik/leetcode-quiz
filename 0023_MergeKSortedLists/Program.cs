using System.Text.Json;

namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.MergeKLists, ArrayK("[]"), Array("[]"));
            Test.Check(solution.MergeKLists, ArrayK("[[]]"), Array("[]"));
            Test.Check(solution.MergeKLists, ArrayK("[[],[]]"), Array("[]"));
            Test.Check(solution.MergeKLists, ArrayK("[[0],[]]"), Array("[0]"));
            Test.Check(solution.MergeKLists, ArrayK("[[0],[],[]]"), Array("[0]"));
            Test.Check(solution.MergeKLists, ArrayK("[[],[0],[]]"), Array("[0]"));
            Test.Check(solution.MergeKLists, ArrayK("[[1],[0],[]]"), Array("[0,1]"));
            Test.Check(solution.MergeKLists, ArrayK("[[],[1],[2],[0],[]]"), Array("[0,1,2]"));
            Test.Check(solution.MergeKLists, ArrayK("[[],[0,1],[2],[0],[]]"), Array("[0,0,1,2]"));
            Test.Check(solution.MergeKLists, ArrayK("[[],[0,1],[1,2],[0],[]]"), Array("[0,0,1,1,2]"));
            Test.Check(solution.MergeKLists, ArrayK("[[],[0,1],[1,2],[0],[2]]"), Array("[0,0,1,1,2,2]"));
            Test.Check(solution.MergeKLists, ArrayK("[[0],[1,2,3,4]]"), Array("[0,1,2,3,4]"));
            Test.Check(solution.MergeKLists, ArrayK("[[0],[1,2,3,4],[5,6,7,8]]"), Array("[0,1,2,3,4,5,6,7,8]"));
        }
        
        private static ListNode Array(string s) {
            int[] n = JsonSerializer.Deserialize<int[]>(s);

            ListNode list_node = null;
            
            for (int i = n.Length - 1; i >= 0; i--) {
                list_node = new ListNode(n[i], list_node);
            }

            return list_node;
        }
        
        private static ListNode[] ArrayK(string s) {
            int[][] nn = JsonSerializer.Deserialize<int[][]>(s);

            ListNode[] list_nodes = new ListNode[nn.Length];
            
            for (int j = 0; j < nn.Length; j++) {
                ListNode list_node = null;
            
                for (int i = nn[j].Length - 1; i >= 0; i--) {
                    list_node = new ListNode(nn[j][i], list_node);
                }

                list_nodes[j] = list_node;
            }
            
            return list_nodes;
        }

    }
}