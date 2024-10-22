using static LeetcodeLib.LinkedListHelper;

namespace Quiz;

public class Program : ProgramBase {

    public static void Main() {
        var solution = new Solution();

        // Test.Print(solution.SortedListToBST, MakeLinkedList("[]"));
        // Test.Print(solution.SortedListToBST, MakeLinkedList("[0]"));
        Test.Print(solution.SortedListToBST, MakeLinkedList("[0,1]"));
        Test.Print(solution.SortedListToBST, MakeLinkedList("[-1,0,1]"));
        Test.Print(solution.SortedListToBST, MakeLinkedList("[-1,0,1,2]"));
        Test.Print(solution.SortedListToBST, MakeLinkedList("[-2,-1,0,1,2]"));
        Test.Print(solution.SortedListToBST, MakeLinkedList("[-3,-2,-1,0,1,2]"));
        Test.Print(solution.SortedListToBST, MakeLinkedList("[-3,-2,-1,0,1,2,3]"));
    }

}
