namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.EvalRPN, StringArray("[\"2\",\"1\",\"+\",\"3\",\"*\"]"), 9);
            Test.Check(solution.EvalRPN, StringArray("[\"4\",\"13\",\"5\",\"/\",\"+\"]"), 6);
            Test.Check(solution.EvalRPN, StringArray("[\"10\",\"6\",\"9\",\"3\",\"+\",\"-11\",\"*\",\"/\",\"*\",\"17\",\"+\",\"5\",\"+\"]"), 22);
        }

    }
}