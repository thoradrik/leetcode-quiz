namespace Quiz;

public class Program : ProgramBase {
    
    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.TimeRequiredToBuy, IntArray("[1]"), 0, 1);
        Test.Check(solution.TimeRequiredToBuy, IntArray("[2]"), 0, 2);
        Test.Check(solution.TimeRequiredToBuy, IntArray("[10]"), 0, 10);
        
        Test.Check(solution.TimeRequiredToBuy, IntArray("[10,1]"), 0, 11);
        Test.Check(solution.TimeRequiredToBuy, IntArray("[10,11]"), 0, 19);
        
        Test.Check(solution.TimeRequiredToBuy, IntArray("[10,1]"), 1, 2);
        Test.Check(solution.TimeRequiredToBuy, IntArray("[10,9]"), 1, 18);
        Test.Check(solution.TimeRequiredToBuy, IntArray("[10,10]"), 1, 20);
        Test.Check(solution.TimeRequiredToBuy, IntArray("[10,11]"), 1, 21);
        
        Test.Check(solution.TimeRequiredToBuy, IntArray("[2,3,2]"), 2, 6);
        Test.Check(solution.TimeRequiredToBuy, IntArray("[5,1,1,1]"), 0, 8);
    }

}
