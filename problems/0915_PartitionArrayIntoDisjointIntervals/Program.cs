namespace Quiz;

public class Program : ProgramBase {

    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.PartitionDisjoint, IntArray("[1,1]"), 1);
        Test.Check(solution.PartitionDisjoint, IntArray("[1,2]"), 1);
        Test.Check(solution.PartitionDisjoint, IntArray("[1,2,2]"), 1);
        Test.Check(solution.PartitionDisjoint, IntArray("[1,1,2]"), 1);
        Test.Check(solution.PartitionDisjoint, IntArray("[1,0,2]"), 2);
        Test.Check(solution.PartitionDisjoint, IntArray("[1,0,2,3]"), 2);
        Test.Check(solution.PartitionDisjoint, IntArray("[1,0,2,0,3]"), 4);
        Test.Check(solution.PartitionDisjoint, IntArray("[1,0,2,1,0,3]"), 5);
        Test.Check(solution.PartitionDisjoint, IntArray("[1,0,2,1,0,3,2]"), 5);
        Test.Check(solution.PartitionDisjoint, IntArray("[1,0,2,1,0,3,2,3]"), 5);
        Test.Check(solution.PartitionDisjoint, IntArray("[1,0,2,1,0,3,2,3,2,4]"), 5);
        Test.Check(solution.PartitionDisjoint, IntArray("[1,0,2,1,0,3,2,3,1,4]"), 9);
        Test.Check(solution.PartitionDisjoint, IntArray("[1,0,2,1,0,3,2,3,0,4]"), 9);
        Test.Check(solution.PartitionDisjoint, IntArray("[5,0,3,8,6]"), 3);
        Test.Check(solution.PartitionDisjoint, IntArray("[1,1,1,0,6,12]"), 4);
    }

}
