namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.FindOcurrences, "alice is a good girl she is a good student", "a", "good", StringArray("[\"girl\",\"student\"]"));
            Test.Check(solution.FindOcurrences, "we will we will rock you", "we", "will", StringArray("[\"we\",\"rock\"]"));
            Test.Check(solution.FindOcurrences, "we will we will rock ", "we", "will", StringArray("[\"we\",\"rock\"]"));
        }

    }
}