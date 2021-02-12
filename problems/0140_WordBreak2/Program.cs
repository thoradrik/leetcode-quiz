namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Print(solution.WordBreak, "catsanddog", StringArray("[\"cat\",\"cats\",\"and\",\"sand\",\"dog\"]"));
            Test.Print(solution.WordBreak, "pineapplepenapple", StringArray("[\"apple\",\"pen\",\"applepen\",\"pine\",\"pineapple\"]"));
        }

    }
}