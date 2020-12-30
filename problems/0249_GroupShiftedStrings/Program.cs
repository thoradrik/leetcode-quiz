namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Print(solution.GroupStrings, StringArray("[\"az\", \"ba\"]"));
            Test.Print(solution.GroupStrings, StringArray("[\"abc\", \"bcd\", \"acef\", \"xyz\", \"az\", \"ba\", \"a\", \"z\"]"));
        }

    }
}