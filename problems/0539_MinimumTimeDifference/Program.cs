namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.FindMinDifference, StringArray("[\"00:00\",\"00:00\"]"), 0);
            Test.Check(solution.FindMinDifference, StringArray("[\"00:00\",\"00:01\"]"), 1);
            Test.Check(solution.FindMinDifference, StringArray("[\"00:00\",\"23:59\"]"), 1);
            Test.Check(solution.FindMinDifference, StringArray("[\"00:00\",\"23:58\"]"), 2);
            Test.Check(solution.FindMinDifference, StringArray("[\"00:00\",\"00:01\",\"23:58\"]"), 1);
            Test.Check(solution.FindMinDifference, StringArray("[\"00:00\",\"00:05\",\"23:55\"]"), 5);
            Test.Check(solution.FindMinDifference, StringArray("[\"00:00\",\"00:05\",\"23:56\"]"), 4);
            Test.Check(solution.FindMinDifference, StringArray("[\"00:00\",\"00:03\",\"23:55\"]"), 3);
            Test.Check(solution.FindMinDifference, StringArray("[\"23:50\",\"00:05\",\"00:25\",\"23:55\"]"), 5);
            Test.Check(solution.FindMinDifference, StringArray("[\"23:10\",\"00:05\",\"00:25\",\"23:55\"]"), 10);
            Test.Check(solution.FindMinDifference, StringArray("[\"23:50\",\"00:05\",\"00:25\",\"00:25\",\"23:55\"]"), 0);
        }

    }
}