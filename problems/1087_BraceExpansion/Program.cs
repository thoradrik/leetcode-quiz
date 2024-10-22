namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Print(solution.Expand, "a");
            Test.Print(solution.Expand, "ab");
            Test.Print(solution.Expand, "abc");
            Test.Print(solution.Expand, "a{b,c}");
            Test.Print(solution.Expand, "a{b,c}d");
            Test.Print(solution.Expand, "a{b,c}{d,e}");
            Test.Print(solution.Expand, "a{b,c}{d,e}f");
            Test.Print(solution.Expand, "a{b,c}{d,e}{f}");
            Test.Print(solution.Expand, "a{b,c}{d,e}{f,g}");
            Test.Print(solution.Expand, "a{b,c}{d,e}{f,g,h}");
            Test.Print(solution.Expand, "{a,b}{z,x,y}");
        }

    }
}
