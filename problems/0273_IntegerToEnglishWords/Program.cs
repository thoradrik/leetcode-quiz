namespace Quiz;

public class Program : ProgramBase {

    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.NumberToWords, 0, "Zero");
        Test.Check(solution.NumberToWords, 1, "One");
        Test.Check(solution.NumberToWords, 2, "Two");
        Test.Check(solution.NumberToWords, 3, "Three");
        Test.Check(solution.NumberToWords, 4, "Four");
        Test.Check(solution.NumberToWords, 5, "Five");
        Test.Check(solution.NumberToWords, 6, "Six");
        Test.Check(solution.NumberToWords, 7, "Seven");
        Test.Check(solution.NumberToWords, 8, "Eight");
        Test.Check(solution.NumberToWords, 9, "Nine");
        Test.Check(solution.NumberToWords, 10, "Ten");
        Test.Check(solution.NumberToWords, 11, "Eleven");
        Test.Check(solution.NumberToWords, 12, "Twelve");
        Test.Check(solution.NumberToWords, 13, "Thirteen");
        Test.Check(solution.NumberToWords, 14, "Fourteen");
        Test.Check(solution.NumberToWords, 15, "Fifteen");
        Test.Check(solution.NumberToWords, 16, "Sixteen");
        Test.Check(solution.NumberToWords, 17, "Seventeen");
        Test.Check(solution.NumberToWords, 18, "Eighteen");
        Test.Check(solution.NumberToWords, 19, "Nineteen");
        Test.Check(solution.NumberToWords, 20, "Twenty");
        Test.Check(solution.NumberToWords, 21, "Twenty One");
        Test.Check(solution.NumberToWords, 28, "Twenty Eight");
        Test.Check(solution.NumberToWords, 32, "Thirty Two");
        Test.Check(solution.NumberToWords, 43, "Forty Three");
        Test.Check(solution.NumberToWords, 57, "Fifty Seven");
        Test.Check(solution.NumberToWords, 69, "Sixty Nine");
        Test.Check(solution.NumberToWords, 74, "Seventy Four");
        Test.Check(solution.NumberToWords, 85, "Eighty Five");
        Test.Check(solution.NumberToWords, 96, "Ninety Six");
        Test.Check(solution.NumberToWords, 100, "One Hundred");
        Test.Check(solution.NumberToWords, 101, "One Hundred One");
        Test.Check(solution.NumberToWords, 200, "Two Hundred");
        Test.Check(solution.NumberToWords, 212, "Two Hundred Twelve");
        Test.Check(solution.NumberToWords, 222, "Two Hundred Twenty Two");
        Test.Check(solution.NumberToWords, 999, "Nine Hundred Ninety Nine");
        Test.Check(solution.NumberToWords, 1000, "One Thousand");
        Test.Check(solution.NumberToWords, 5000, "Five Thousand");
        Test.Check(solution.NumberToWords, 5100, "Five Thousand One Hundred");
        Test.Check(solution.NumberToWords, 5102, "Five Thousand One Hundred Two");
        Test.Check(solution.NumberToWords, 1842, "One Thousand Eight Hundred Forty Two");
        Test.Check(solution.NumberToWords, 12345, "Twelve Thousand Three Hundred Forty Five");
        Test.Check(solution.NumberToWords, 1234567, "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven");
        Test.Check(solution.NumberToWords, 12345678, "Twelve Million Three Hundred Forty Five Thousand Six Hundred Seventy Eight");
        Test.Check(solution.NumberToWords, 123456780, "One Hundred Twenty Three Million Four Hundred Fifty Six Thousand Seven Hundred Eighty");
        Test.Check(solution.NumberToWords, 123456789, "One Hundred Twenty Three Million Four Hundred Fifty Six Thousand Seven Hundred Eighty Nine");
        Test.Check(solution.NumberToWords, 1234567890, "One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety");
        Test.Check(solution.NumberToWords, 2134567811, "Two Billion One Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Eleven");
    }

}
