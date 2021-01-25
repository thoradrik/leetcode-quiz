namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.IsHappy, 1, true);
            Test.Check(solution.IsHappy, 2, false);
            Test.Check(solution.IsHappy, 10, true);
            Test.Check(solution.IsHappy, 19, true);
            Test.Check(solution.IsHappy, 191, false);
            Test.Check(solution.IsHappy, 192, true);
            Test.Check(solution.IsHappy, 1024, false);
            Test.Check(solution.IsHappy, 2048, false);
            Test.Check(solution.IsHappy, 4096, true);
            Test.Check(solution.IsHappy, 1926, false);
            Test.Check(solution.IsHappy, 13, true);
            Test.Check(solution.IsHappy, 103, true);
            Test.Check(solution.IsHappy, 31, true);
            Test.Check(solution.IsHappy, 301, true);
            Test.Check(solution.IsHappy, 68, true);
            Test.Check(solution.IsHappy, 608, true);
            Test.Check(solution.IsHappy, 86, true);
            Test.Check(solution.IsHappy, 806, true);
            Test.Check(solution.IsHappy, 807, false);
            Test.Check(solution.IsHappy, 8070, false);
            Test.Check(solution.IsHappy, 80701, false);
            Test.Check(solution.IsHappy, 807012, false);
            Test.Check(solution.IsHappy, 8070124, false);
            Test.Check(solution.IsHappy, 80701245, false);
            Test.Check(solution.IsHappy, 2147079784, true);
            Test.Check(solution.IsHappy, 2147041584, true);
            Test.Check(solution.IsHappy, 2147079756, true);
            /*
            for (int i = 0; i <= 100; i++) {
                if (solution.IsHappy(i)) {
                    Console.WriteLine(i);
                } 
            }

            for (int i = Int32.MaxValue; i >= 0; i--) {
                if (solution.IsHappy(i)) {
                    Console.WriteLine(i);
                } 
            }
            */
        }

    }
}