namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.ReverseString2, CharArray("[]"), CharArray("[]"));
            Test.Check(solution.ReverseString2, CharArray("[\"a\"]"), CharArray("[\"a\"]"));
            Test.Check(solution.ReverseString2, CharArray("[\"a\",\"b\"]"), CharArray("[\"b\",\"a\"]"));
            Test.Check(solution.ReverseString2, CharArray("[\"h\",\"e\",\"l\",\"l\",\"o\"]"), CharArray("[\"o\",\"l\",\"l\",\"e\",\"h\"]"));
        }

    }
}
