namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.MaxDepth, "", 0);
            Test.Check(solution.MaxDepth, "()(D)", 1);
            Test.Check(solution.MaxDepth, "(A)((B)(C))", 2);
            Test.Check(solution.MaxDepth, "(1+(2*3)+((8)/4))+1", 3);
            Test.Check(solution.MaxDepth, "(1)+((2))+(((3)))", 3);
            Test.Check(solution.MaxDepth, "1+(2*3)/(2-1)", 1);
        }

    }
}