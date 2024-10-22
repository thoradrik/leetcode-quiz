namespace Quiz;

public class Program : ProgramBase {

    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.SumOfMultiples, 3, 3);
        Test.Check(solution.SumOfMultiples, 4, 3);
        Test.Check(solution.SumOfMultiples, 5, 8);
        Test.Check(solution.SumOfMultiples, 6, 14);
        Test.Check(solution.SumOfMultiples, 7, 21);
        Test.Check(solution.SumOfMultiples, 9, 30);
        Test.Check(solution.SumOfMultiples, 10, 40);
        Test.Check(solution.SumOfMultiples, 11, 40);
        Test.Check(solution.SumOfMultiples, 12, 52);
        Test.Check(solution.SumOfMultiples, 13, 52);
        Test.Check(solution.SumOfMultiples, 14, 66);
        Test.Check(solution.SumOfMultiples, 15, 81);
    }

}
