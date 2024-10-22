namespace Quiz;

public class Program : ProgramBase {

    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.LongestConsecutive, IntArray("[]"), 0);
        Test.Check(solution.LongestConsecutive, IntArray("[1]"), 1);
        Test.Check(solution.LongestConsecutive, IntArray("[1,3]"), 1);
        Test.Check(solution.LongestConsecutive, IntArray("[1,3,2]"), 3);
        Test.Check(solution.LongestConsecutive, IntArray("[1,4,2]"), 2);
        Test.Check(solution.LongestConsecutive, IntArray("[4,3,2,1]"), 4);
        Test.Check(solution.LongestConsecutive, IntArray("[1,2,0,1]"), 3);
        Test.Check(solution.LongestConsecutive, IntArray("[100,4,200,1,2]"), 2);
        Test.Check(solution.LongestConsecutive, IntArray("[100,4,200,1,3,2]"), 4);
        Test.Check(solution.LongestConsecutive, IntArray("[0,3,7,2,5,8,4,6,0,1]"), 9);
    }

}
