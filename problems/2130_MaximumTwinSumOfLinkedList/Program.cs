using static LeetcodeLib.LinkedListHelper;

namespace Quiz;

public class Program : ProgramBase {
    
    public static void Main() {
        Solution solution = new Solution();

        Test.Check(solution.PairSum, MakeLinkedList("[-1,1]"), 0);
        Test.Check(solution.PairSum, MakeLinkedList("[0,1]"), 1);
        Test.Check(solution.PairSum, MakeLinkedList("[1,1,1,1]"), 2);
        Test.Check(solution.PairSum, MakeLinkedList("[1,2,1,1]"), 3);
        Test.Check(solution.PairSum, MakeLinkedList("[1,2,1,2]"), 3);
        Test.Check(solution.PairSum, MakeLinkedList("[1,2,1,4]"), 5);
        Test.Check(solution.PairSum, MakeLinkedList("[5,1,2,1,4,1]"), 6);
        Test.Check(solution.PairSum, MakeLinkedList("[5,2,6,1,4,-5]"), 7);
        Test.Check(solution.PairSum, MakeLinkedList("[5,2,2,1,4,5]"), 10);
        Test.Check(solution.PairSum, MakeLinkedList("[5,2,2,10,2,1,4,5]"), 12);
    }

}
