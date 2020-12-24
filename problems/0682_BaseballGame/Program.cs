namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.CalPoints, StringArray("[\"1\"]"), 1);
            Test.Check(solution.CalPoints, StringArray("[\"1\",\"2\"]"), 3);
            Test.Check(solution.CalPoints, StringArray("[\"5\",\"2\",\"C\",\"D\",\"+\"]"), 30);
            Test.Check(solution.CalPoints, StringArray("[\"5\",\"-2\",\"4\",\"C\",\"D\",\"9\",\"+\",\"+\"]"), 27);
        }

    }
}