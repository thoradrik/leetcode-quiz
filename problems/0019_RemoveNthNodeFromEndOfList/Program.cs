using static LeetcodeLib.LinkedListHelper;

namespace Quiz;

public class Program : ProgramBase {

    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.RemoveNthFromEnd, MakeLinkedList("[0]"), 1, MakeLinkedList("[]"));
        Test.Check(solution.RemoveNthFromEnd, MakeLinkedList("[0,1]"), 1, MakeLinkedList("[0]"));
        Test.Check(solution.RemoveNthFromEnd, MakeLinkedList("[0,1]"), 2, MakeLinkedList("[1]"));
        Test.Check(solution.RemoveNthFromEnd, MakeLinkedList("[0,1,2]"), 1, MakeLinkedList("[0,1]"));
        Test.Check(solution.RemoveNthFromEnd, MakeLinkedList("[0,1,2]"), 2, MakeLinkedList("[0,2]"));
        Test.Check(solution.RemoveNthFromEnd, MakeLinkedList("[0,1,2]"), 3, MakeLinkedList("[1,2]"));
        Test.Check(solution.RemoveNthFromEnd, MakeLinkedList("[0,1,2,3]"), 1, MakeLinkedList("[0,1,2]"));
        Test.Check(solution.RemoveNthFromEnd, MakeLinkedList("[0,1,2,3]"), 2, MakeLinkedList("[0,1,3]"));
        Test.Check(solution.RemoveNthFromEnd, MakeLinkedList("[0,1,2,3]"), 3, MakeLinkedList("[0,2,3]"));
        Test.Check(solution.RemoveNthFromEnd, MakeLinkedList("[0,1,2,3]"), 4, MakeLinkedList("[1,2,3]"));
    }

}
