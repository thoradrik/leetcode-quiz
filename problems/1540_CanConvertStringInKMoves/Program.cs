namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.CanConvertString, "a", "b", 1, true);
            Test.Check(solution.CanConvertString, "a", "c", 1, false);
            Test.Check(solution.CanConvertString, "a", "c", 2, true);
            Test.Check(solution.CanConvertString, "input", "ouput", 9, true);
            Test.Check(solution.CanConvertString, "abc", "bcd", 10, false);
            Test.Check(solution.CanConvertString, "aab", "bbb", 27, true);
        }

    }
}