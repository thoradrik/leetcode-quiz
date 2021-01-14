namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            for (int i = 0; i < 20; i++) {
                Test.Check(solution.AddOperators, "", 1, StringArray("[]"));
                Test.Check(solution.AddOperators, "1", 2, StringArray("[]"));
                Test.Check(solution.AddOperators, "2", 2, StringArray("[\"2\"]"));
                Test.Check(solution.AddOperators, "22", 4, StringArray("[\"2+2\",\"2*2\"]"));
                Test.Print(solution.AddOperators, "123", 6);
                Test.Print(solution.AddOperators, "232", 8);
                Test.Print(solution.AddOperators, "105", 5);
                Test.Print(solution.AddOperators, "00", 0);
                Test.Check(solution.AddOperators, "3456237490", 9191, StringArray("[]"));
                Test.Check(solution.AddOperators, "2147483648", -2147483648, StringArray("[]"));
                Test.Check(solution.AddOperators, "2147483647", 2147483647, StringArray("[\"2147483647\"]"));
            }
        }

    }
}