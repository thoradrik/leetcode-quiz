namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.MinOperations, StringArray("[\"d1/\",\"d2/\",\"../\",\"d21/\",\"./\"]"), 2);
            Test.Check(solution.MinOperations, StringArray("[\"d1/\",\"d2/\",\"./\",\"d3/\",\"../\",\"d31/\"]"), 3);
            Test.Check(solution.MinOperations, StringArray("[\"d1/\",\"../\",\"../\",\"../\"]"), 0);
        }

    }
}