namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Print(solution.Combine, 1, 1);
            Test.Print(solution.Combine, 4, 2);
            Test.Print(solution.Combine, 20, 20);
            Test.Print(solution.Combine, 20, 19);
            Test.Print(solution.Combine, 20, 18);
            Test.Print(solution.Combine, 10, 5);
        }

    }
}