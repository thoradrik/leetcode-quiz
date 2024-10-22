namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Print(solution.LetterCombinations, "");
            Test.Print(solution.LetterCombinations, "2");
            Test.Print(solution.LetterCombinations, "23");
            Test.Print(solution.LetterCombinations, "234");
            Test.Print(solution.LetterCombinations, "222");
            Test.Print(solution.LetterCombinations, "2427");
            Test.Print(solution.LetterCombinations, "2345");
            Test.Print(solution.LetterCombinations, "6789");
        }

    }
}
