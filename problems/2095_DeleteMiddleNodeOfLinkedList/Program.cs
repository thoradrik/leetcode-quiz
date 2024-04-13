using static LeetcodeLib.LinkedListHelper;

namespace Quiz;

public class Program : ProgramBase {
    
    public static void Main() {
        Solution solution = new Solution();
        
        Test.Check(solution.DeleteMiddle, MakeLinkedList("[0]"),  MakeLinkedList("[]"));
        Test.Check(solution.DeleteMiddle, MakeLinkedList("[1,2]"), MakeLinkedList("[1]"));
        Test.Check(solution.DeleteMiddle, MakeLinkedList("[1,2,3]"), MakeLinkedList("[1,3]"));
        Test.Check(solution.DeleteMiddle, MakeLinkedList("[1,2,3,4]"), MakeLinkedList("[1,2,4]"));
        Test.Check(solution.DeleteMiddle, MakeLinkedList("[1,2,3,4,5]"), MakeLinkedList("[1,2,4,5]"));
        Test.Check(solution.DeleteMiddle, MakeLinkedList("[1,2,3,4,5,6]"), MakeLinkedList("[1,2,3,5,6]"));
        Test.Check(solution.DeleteMiddle, MakeLinkedList("[1,2,3,4,5,6,7]"), MakeLinkedList("[1,2,3,5,6,7]"));
        Test.Check(solution.DeleteMiddle, MakeLinkedList("[1,2,3,4,5,6,7,8]"), MakeLinkedList("[1,2,3,4,6,7,8]"));
        Test.Check(solution.DeleteMiddle, MakeLinkedList("[1,2,3,4,5,6,7,8,9]"), MakeLinkedList("[1,2,3,4,6,7,8,9]"));
    }

}
