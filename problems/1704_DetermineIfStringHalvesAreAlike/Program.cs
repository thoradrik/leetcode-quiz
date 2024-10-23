namespace Quiz;

public class Program : ProgramBase {

    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.HalvesAreAlike, "ok", false);
        Test.Check(solution.HalvesAreAlike, "zz", true);
        Test.Check(solution.HalvesAreAlike, "book", true);
        Test.Check(solution.HalvesAreAlike, "take", true);
        Test.Check(solution.HalvesAreAlike, "textbook", false);
        Test.Check(solution.HalvesAreAlike, "cookbook", true);
        Test.Check(solution.HalvesAreAlike, "quicbaek", true);
    }

}
