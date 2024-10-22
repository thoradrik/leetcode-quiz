namespace Quiz;

public class Program : ProgramBase {

    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.RomanToInt, "I", 1);
        Test.Check(solution.RomanToInt, "II", 2);
        Test.Check(solution.RomanToInt, "III", 3);
        Test.Check(solution.RomanToInt, "IV", 4);
        Test.Check(solution.RomanToInt, "V", 5);
        Test.Check(solution.RomanToInt, "VI", 6);
        Test.Check(solution.RomanToInt, "VII", 7);
        Test.Check(solution.RomanToInt, "VIII", 8);
        Test.Check(solution.RomanToInt, "IX", 9);
        Test.Check(solution.RomanToInt, "X", 10);
        Test.Check(solution.RomanToInt, "XI", 11);
        Test.Check(solution.RomanToInt, "XII", 12);
        Test.Check(solution.RomanToInt, "XIII", 13);
        Test.Check(solution.RomanToInt, "XIV", 14);
        Test.Check(solution.RomanToInt, "XV", 15);
        Test.Check(solution.RomanToInt, "XXIV", 24);
        Test.Check(solution.RomanToInt, "XXV", 25);
        Test.Check(solution.RomanToInt, "XL", 40);
        Test.Check(solution.RomanToInt, "L", 50);
        Test.Check(solution.RomanToInt, "XC", 90);
        Test.Check(solution.RomanToInt, "C", 100);
        Test.Check(solution.RomanToInt, "CD", 400);
        Test.Check(solution.RomanToInt, "CM", 900);
        Test.Check(solution.RomanToInt, "D", 500);
        Test.Check(solution.RomanToInt, "M", 1000);
        Test.Check(solution.RomanToInt, "MCMXCIV", 1994);
        Test.Check(solution.RomanToInt, "MMMDCCXLIX", 3749);
    }

}
