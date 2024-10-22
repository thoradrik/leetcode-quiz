namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.LengthOfLastWord, "", 0);
            Test.Check(solution.LengthOfLastWord, "H", 1);
            Test.Check(solution.LengthOfLastWord, " H ", 1);
            Test.Check(solution.LengthOfLastWord, "Hell", 4);
            Test.Check(solution.LengthOfLastWord, "Hell ", 4);
            Test.Check(solution.LengthOfLastWord, "Hello", 5);
            Test.Check(solution.LengthOfLastWord, "Hello ", 5);
            Test.Check(solution.LengthOfLastWord, "Hello World", 5);
            Test.Check(solution.LengthOfLastWord, "Hello World X ", 1);
            Test.Check(solution.LengthOfLastWord, "Hello World XXX  ", 3);
        }

    }
}
