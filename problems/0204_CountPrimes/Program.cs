namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.CountPrimes, 0, 0);
            Test.Check(solution.CountPrimes, 1, 0);
            Test.Check(solution.CountPrimes, 2, 0);
            Test.Check(solution.CountPrimes, 3, 1);
            Test.Check(solution.CountPrimes, 4, 2);
            Test.Check(solution.CountPrimes, 5, 2);
            Test.Check(solution.CountPrimes, 6, 3);
            Test.Check(solution.CountPrimes, 7, 3);
            Test.Check(solution.CountPrimes, 8, 4);
            Test.Check(solution.CountPrimes, 11, 4);
            Test.Check(solution.CountPrimes, 12, 5);
            Test.Check(solution.CountPrimes, 13, 5);
            Test.Check(solution.CountPrimes, 14, 6);
            Test.Check(solution.CountPrimes, 1024, 172);
            Test.Check(solution.CountPrimes, 65535, 6542);
            Test.Check(solution.CountPrimes, 655350, 53226);
            Test.Check(solution.CountPrimes, 1048576, 82025);
            Test.Check(solution.CountPrimes, 16777216, 1077871);
        }

    }
}