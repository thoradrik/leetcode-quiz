namespace Quiz;

using static LinkedListHelper;

public class Program : ProgramBase {

    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.HasCycle, (ListNode)null, false);
        Test.Check(solution.HasCycle, LinkedList("[1]", 0), true);
        Test.Check(solution.HasCycle, LinkedList("[1]", -1), false);
        Test.Check(solution.HasCycle, LinkedList("[1,2]", 0), true);
        Test.Check(solution.HasCycle, LinkedList("[1,2]", 1), true);
        Test.Check(solution.HasCycle, LinkedList("[1,2]", -1), false);
        Test.Check(solution.HasCycle, LinkedList("[3,2,0,-4]", 0), true);
        Test.Check(solution.HasCycle, LinkedList("[3,2,0,-4]", 1), true);
        Test.Check(solution.HasCycle, LinkedList("[3,2,0,-4]", 2), true);
        Test.Check(solution.HasCycle, LinkedList("[3,2,0,-4]", 3), true);
        Test.Check(solution.HasCycle, LinkedList("[3,2,0,-4]", -1), false);
    }

}