using static Quiz.LinkedListHelper;

namespace Quiz;

public class Program : ProgramBase {

    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.MergeKLists, ArrayK("[]"), Array("[]"));
        Test.Check(solution.MergeKLists, ArrayK("[[]]"), Array("[]"));
        Test.Check(solution.MergeKLists, ArrayK("[[],[]]"), Array("[]"));
        Test.Check(solution.MergeKLists, ArrayK("[[0],[]]"), Array("[0]"));
        Test.Check(solution.MergeKLists, ArrayK("[[0],[],[]]"), Array("[0]"));
        Test.Check(solution.MergeKLists, ArrayK("[[],[0],[]]"), Array("[0]"));
        Test.Check(solution.MergeKLists, ArrayK("[[1],[0],[]]"), Array("[0,1]"));
        Test.Check(solution.MergeKLists, ArrayK("[[],[1],[2],[0],[]]"), Array("[0,1,2]"));
        Test.Check(solution.MergeKLists, ArrayK("[[],[0,1],[2],[0],[]]"), Array("[0,0,1,2]"));
        Test.Check(solution.MergeKLists, ArrayK("[[],[0,1],[1,2],[0],[]]"), Array("[0,0,1,1,2]"));
        Test.Check(solution.MergeKLists, ArrayK("[[],[0,1],[1,2],[0],[2]]"), Array("[0,0,1,1,2,2]"));
        Test.Check(solution.MergeKLists, ArrayK("[[0],[1,2,3,4]]"), Array("[0,1,2,3,4]"));
        Test.Check(solution.MergeKLists, ArrayK("[[0],[1,2,3,4],[5,6,7,8]]"), Array("[0,1,2,3,4,5,6,7,8]"));
    }

}