using static Quiz.LinkedListHelper;

namespace Quiz;

public class Program : ProgramBase {

    public static void Main() {
        var solution = new Solution();

        ListNode[] nodes;

        Test.Check(solution.DetectCycle, (ListNode)null, (ListNode)null);
        Test.Check(solution.DetectCycle, LinkedList("[1]", 0, out nodes), nodes[0]);
        Test.Check(solution.DetectCycle, LinkedList("[1]", -1, out nodes), (ListNode)null);
        Test.Check(solution.DetectCycle, LinkedList("[1,2]", 0, out nodes), nodes[0]);
        Test.Check(solution.DetectCycle, LinkedList("[1,2]", 1, out nodes), nodes[1]);
        Test.Check(solution.DetectCycle, LinkedList("[1,2]", -1, out nodes), (ListNode)null);
        Test.Check(solution.DetectCycle, LinkedList("[3,2,0,-4]", 0, out nodes), nodes[0]);
        Test.Check(solution.DetectCycle, LinkedList("[3,2,0,-4]", 1, out nodes), nodes[1]);
        Test.Check(solution.DetectCycle, LinkedList("[3,2,0,-4]", 2, out nodes), nodes[2]);
        Test.Check(solution.DetectCycle, LinkedList("[3,2,0,-4]", 3, out nodes), nodes[3]);
        Test.Check(solution.DetectCycle, LinkedList("[3,2,0,-4]", -1, out nodes), (ListNode)null);
    }

}
