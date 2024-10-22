namespace Quiz;

public class Program : ProgramBase {
    
    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.CountStudents, IntArray("[0]"), IntArray("[0]"), 0);
        Test.Check(solution.CountStudents, IntArray("[0]"), IntArray("[1]"), 1);
        Test.Check(solution.CountStudents, IntArray("[1]"), IntArray("[1]"), 0);
        Test.Check(solution.CountStudents, IntArray("[1]"), IntArray("[0]"), 1);
        
        Test.Check(solution.CountStudents, IntArray("[0,0]"), IntArray("[0,0]"), 0);
        Test.Check(solution.CountStudents, IntArray("[0,0]"), IntArray("[1,0]"), 2);

        Test.Check(solution.CountStudents, IntArray("[0,0]"), IntArray("[0,1]"), 1);
        Test.Check(solution.CountStudents, IntArray("[0,0]"), IntArray("[1,1]"), 2);

        Test.Check(solution.CountStudents, IntArray("[1,1]"), IntArray("[0,0]"), 2);
        Test.Check(solution.CountStudents, IntArray("[1,1]"), IntArray("[1,0]"), 1);

        Test.Check(solution.CountStudents, IntArray("[1,1]"), IntArray("[0,1]"), 2);
        Test.Check(solution.CountStudents, IntArray("[1,1]"), IntArray("[1,1]"), 0);
        
        Test.Check(solution.CountStudents, IntArray("[1,1,0,0]"), IntArray("[0,1,0,1]"), 0);
        Test.Check(solution.CountStudents, IntArray("[1,1,1,0,0,1]"), IntArray("[1,0,0,0,1,1]"), 3);
    }

}
