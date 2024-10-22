namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Print(solution.LetterCasePermutation, "");
            Test.Print(solution.LetterCasePermutation, "1");
            Test.Print(solution.LetterCasePermutation, "a1");
            Test.Print(solution.LetterCasePermutation, "A1");
            Test.Print(solution.LetterCasePermutation, "a1b");
            Test.Print(solution.LetterCasePermutation, "a1B");
            Test.Print(solution.LetterCasePermutation, "2a1B4c");
            Test.Print(solution.LetterCasePermutation, "2a1B4cd");
            Test.Print(solution.LetterCasePermutation, "z2a1B4cdIP");
        }

    }
}
