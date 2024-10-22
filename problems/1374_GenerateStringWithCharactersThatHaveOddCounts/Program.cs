namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.GenerateTheString, 0, "");
            Test.Check(solution.GenerateTheString, 1, "a");
            Test.Check(solution.GenerateTheString, 2, "ab");
            Test.Check(solution.GenerateTheString, 3, "aaa");
            Test.Check(solution.GenerateTheString, 4, "aaab");
            Test.Check(solution.GenerateTheString, 5, "aaaaa");
            Test.Check(solution.GenerateTheString, 6, "aaaaab");
            Test.Check(solution.GenerateTheString, 7, "aaaaaaa");
            Test.Check(solution.GenerateTheString, 8, "aaaaaaab");
            Test.Check(solution.GenerateTheString, 9, "aaaaaaaaa");
        }

    }
}