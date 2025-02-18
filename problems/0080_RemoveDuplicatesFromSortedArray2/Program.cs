namespace Quiz;

public class Program : ProgramBase {

    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.RemoveDuplicates, IntArray("[-1]"), 1);
        Test.Check(solution.RemoveDuplicates, IntArray("[1,1]"), 2);
        Test.Check(solution.RemoveDuplicates, IntArray("[1,1,2]"), 3);
        Test.Check(solution.RemoveDuplicates, IntArray("[1,1,2,2]"), 4);
        Test.Check(solution.RemoveDuplicates, IntArray("[1,1,2,2,2]"), 4);
        Test.Check(solution.RemoveDuplicates, IntArray("[1,1,2,2,2,3]"), 5);
        Test.Check(solution.RemoveDuplicates, IntArray("[1,1,1,2,2,2,3]"), 5);
        Test.Check(solution.RemoveDuplicates, IntArray("[1,1,1,2,2,2,3,3]"), 6);
        Test.Check(solution.RemoveDuplicates, IntArray("[1,1,1,2,2,2,3,3,3]"), 6);
        Test.Check(solution.RemoveDuplicates, IntArray("[1,1,1,1,2,2,2,2,3,3,3,3]"), 6);
        Test.Check(solution.RemoveDuplicates, IntArray("[1,1,1,1,2,2,2,2,3,3,3,3,3]"), 6);
        Test.Check(solution.RemoveDuplicates, IntArray("[1,1,1,1,2,2,2,2,3,3,3,3,3,4]"), 7);
        Test.Check(solution.RemoveDuplicates, IntArray("[0,0,1,1,1,1,2,3,3]"), 7);
    }

}
