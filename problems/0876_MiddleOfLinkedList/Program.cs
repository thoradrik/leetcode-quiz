using static LeetcodeLib.LinkedListHelper;

namespace Quiz;

public class Program : ProgramBase {
    
    public static void Main() {
        Solution solution = new Solution();

        ListNode item;
        
        Test.Check(solution.MiddleNode, MakeLinkedList("[0]", 0, out item), item);
        Test.Check(solution.MiddleNode, MakeLinkedList("[1,2]", 1, out item), item);
        Test.Check(solution.MiddleNode, MakeLinkedList("[1,2,3]", 1, out item), item);
        Test.Check(solution.MiddleNode, MakeLinkedList("[1,2,3,4]", 2, out item), item);
        Test.Check(solution.MiddleNode, MakeLinkedList("[1,2,3,4,5]", 2, out item), item);
        Test.Check(solution.MiddleNode, MakeLinkedList("[1,2,3,4,5,6]", 3, out item), item);
        Test.Check(solution.MiddleNode, MakeLinkedList("[1,2,3,4,5,6,7]", 3, out item), item);
        Test.Check(solution.MiddleNode, MakeLinkedList("[1,2,3,4,5,6,7,8]", 4, out item), item);
        Test.Check(solution.MiddleNode, MakeLinkedList("[1,2,3,4,5,6,7,8,9]", 4, out item), item);
    }

}
