using System.Text.Json;

namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.MergeTwoLists, LinkedList("[]"), LinkedList("[]"), LinkedList("[]"));
            Test.Check(solution.MergeTwoLists, LinkedList("[0]"), LinkedList("[]"), LinkedList("[0]"));
            Test.Check(solution.MergeTwoLists, LinkedList("[]"), LinkedList("[0]"), LinkedList("[0]"));
            Test.Check(solution.MergeTwoLists, LinkedList("[0]"), LinkedList("[0]"), LinkedList("[0,0]"));
            Test.Check(solution.MergeTwoLists, LinkedList("[0,1]"), LinkedList("[]"), LinkedList("[0,1]"));
            Test.Check(solution.MergeTwoLists, LinkedList("[]"), LinkedList("[0,1]"), LinkedList("[0,1]"));
            Test.Check(solution.MergeTwoLists, LinkedList("[0]"), LinkedList("[1]"), LinkedList("[0,1]"));
            Test.Check(solution.MergeTwoLists, LinkedList("[0,2]"), LinkedList("[1,3]"), LinkedList("[0,1,2,3]"));
            Test.Check(solution.MergeTwoLists, LinkedList("[0,2,3]"), LinkedList("[1,3]"), LinkedList("[0,1,2,3,3]"));
            Test.Check(solution.MergeTwoLists, LinkedList("[0,2,3]"), LinkedList("[1,3,4]"), LinkedList("[0,1,2,3,3,4]"));
        }
        
        private static ListNode LinkedList(string s) {
            int[] n = JsonSerializer.Deserialize<int[]>(s);

            ListNode list_node = null;
            
            for (int i = n.Length - 1; i >= 0; i--) {
                list_node = new ListNode(n[i], list_node);
            }

            return list_node;
        }

    }
}