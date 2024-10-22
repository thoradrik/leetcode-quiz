namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.LongestWord, StringArray("[\"a\",\"banana\",\"app\",\"appl\",\"ap\",\"apply\",\"apple\"]"), "apple");
            Test.Check(solution.LongestWord, StringArray("[\"w\",\"wo\",\"wor\",\"worl\",\"world\"]"), "world");
        }

    }
}
