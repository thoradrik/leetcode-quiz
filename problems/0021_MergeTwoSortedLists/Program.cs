using static LeetcodeLib.LinkedListHelper;

namespace Quiz;

public class Program : ProgramBase {
        
    public static void Main() {
        Solution solution = new Solution();

        Test.Check(solution.MergeTwoLists, MakeLinkedList("[]"), MakeLinkedList("[]"), MakeLinkedList("[]"));
        Test.Check(solution.MergeTwoLists, MakeLinkedList("[0]"), MakeLinkedList("[]"), MakeLinkedList("[0]"));
        Test.Check(solution.MergeTwoLists, MakeLinkedList("[]"), MakeLinkedList("[0]"), MakeLinkedList("[0]"));
        Test.Check(solution.MergeTwoLists, MakeLinkedList("[0]"), MakeLinkedList("[0]"), MakeLinkedList("[0,0]"));
        Test.Check(solution.MergeTwoLists, MakeLinkedList("[0,1]"), MakeLinkedList("[]"), MakeLinkedList("[0,1]"));
        Test.Check(solution.MergeTwoLists, MakeLinkedList("[]"), MakeLinkedList("[0,1]"), MakeLinkedList("[0,1]"));
        Test.Check(solution.MergeTwoLists, MakeLinkedList("[0]"), MakeLinkedList("[1]"), MakeLinkedList("[0,1]"));
        Test.Check(solution.MergeTwoLists, MakeLinkedList("[0,2]"), MakeLinkedList("[1,3]"), MakeLinkedList("[0,1,2,3]"));
        Test.Check(solution.MergeTwoLists, MakeLinkedList("[0,2,3]"), MakeLinkedList("[1,3]"), MakeLinkedList("[0,1,2,3,3]"));
        Test.Check(solution.MergeTwoLists, MakeLinkedList("[0,2,3]"), MakeLinkedList("[1,3,4]"), MakeLinkedList("[0,1,2,3,3,4]"));
    }

}