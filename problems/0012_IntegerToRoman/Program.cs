namespace Quiz;

public class Program : ProgramBase {

    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.IntToRoman, 1, "I");
        Test.Check(solution.IntToRoman, 2, "II");
        Test.Check(solution.IntToRoman, 3, "III");
        Test.Check(solution.IntToRoman, 4, "IV");
        Test.Check(solution.IntToRoman, 5, "V");
        Test.Check(solution.IntToRoman, 6, "VI");
        Test.Check(solution.IntToRoman, 7, "VII");
        Test.Check(solution.IntToRoman, 8, "VIII");
        Test.Check(solution.IntToRoman, 9, "IX");
        Test.Check(solution.IntToRoman, 10, "X");
        Test.Check(solution.IntToRoman, 11, "XI");
        Test.Check(solution.IntToRoman, 12, "XII");
        Test.Check(solution.IntToRoman, 13, "XIII");
        Test.Check(solution.IntToRoman, 14, "XIV");
        Test.Check(solution.IntToRoman, 15, "XV");
        Test.Check(solution.IntToRoman, 24, "XXIV");
        Test.Check(solution.IntToRoman, 25, "XXV");
        Test.Check(solution.IntToRoman, 40, "XL");
        Test.Check(solution.IntToRoman, 50, "L");
        Test.Check(solution.IntToRoman, 58, "LVIII");
        Test.Check(solution.IntToRoman, 90, "XC");
        Test.Check(solution.IntToRoman, 100, "C");
        Test.Check(solution.IntToRoman, 400, "CD");
        Test.Check(solution.IntToRoman, 900, "CM");
        Test.Check(solution.IntToRoman, 500, "D");
        Test.Check(solution.IntToRoman, 1000, "M");
        Test.Check(solution.IntToRoman, 1994, "MCMXCIV");
        Test.Check(solution.IntToRoman, 3749, "MMMDCCXLIX");
    }

}
