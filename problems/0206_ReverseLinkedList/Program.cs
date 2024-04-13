using static LeetcodeLib.LinkedListHelper;

namespace Quiz;

public class Program : ProgramBase {
        
    public static void Main() {
        Solution solution = new Solution();

        Test.Check(solution.ReverseList, MakeLinkedList("[]"), MakeLinkedList("[]"));
        Test.Check(solution.ReverseList, MakeLinkedList("[1]"), MakeLinkedList("[1]"));
        Test.Check(solution.ReverseList, MakeLinkedList("[1,2]"), MakeLinkedList("[2,1]"));
        Test.Check(solution.ReverseList, MakeLinkedList("[1,2,3]"), MakeLinkedList("[3,2,1]"));
        Test.Check(solution.ReverseList, MakeLinkedList("[1,2,3,4]"), MakeLinkedList("[4,3,2,1]"));
        Test.Check(solution.ReverseList, MakeLinkedList("[1,2,3,4,5]"), MakeLinkedList("[5,4,3,2,1]"));
    }

}