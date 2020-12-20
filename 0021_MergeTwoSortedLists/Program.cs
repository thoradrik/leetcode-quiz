using System.Text.Json;

namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.MergeTwoLists, Array("[]"), Array("[]"), Array("[]"));
            Test.Check(solution.MergeTwoLists, Array("[0]"), Array("[]"), Array("[0]"));
            Test.Check(solution.MergeTwoLists, Array("[]"), Array("[0]"), Array("[0]"));
            Test.Check(solution.MergeTwoLists, Array("[0]"), Array("[0]"), Array("[0,0]"));
            Test.Check(solution.MergeTwoLists, Array("[0,1]"), Array("[]"), Array("[0,1]"));
            Test.Check(solution.MergeTwoLists, Array("[]"), Array("[0,1]"), Array("[0,1]"));
            Test.Check(solution.MergeTwoLists, Array("[0]"), Array("[1]"), Array("[0,1]"));
            Test.Check(solution.MergeTwoLists, Array("[0,2]"), Array("[1,3]"), Array("[0,1,2,3]"));
            Test.Check(solution.MergeTwoLists, Array("[0,2,3]"), Array("[1,3]"), Array("[0,1,2,3,3]"));
            Test.Check(solution.MergeTwoLists, Array("[0,2,3]"), Array("[1,3,4]"), Array("[0,1,2,3,3,4]"));
        }
        
        private static ListNode Array(string s) {
            int[] n = JsonSerializer.Deserialize<int[]>(s);

            ListNode list_node = null;
            
            for (int i = n.Length - 1; i >= 0; i--) {
                list_node = new ListNode(n[i], list_node);
            }

            return list_node;
        }

    }
}