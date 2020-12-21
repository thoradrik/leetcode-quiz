namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.AddStrings, "0", "0", "0");
            Test.Check(solution.AddStrings, "0", "1", "1");
            Test.Check(solution.AddStrings, "1", "0", "1");
            Test.Check(solution.AddStrings, "1", "1", "2");
            Test.Check(solution.AddStrings, "10", "1", "11");
            Test.Check(solution.AddStrings, "0", "11", "11");
            Test.Check(solution.AddStrings, "11", "0", "11");
            Test.Check(solution.AddStrings, "1", "11", "12");
            Test.Check(solution.AddStrings, "11", "11", "22");
            Test.Check(solution.AddStrings, "1234568", "897561646", "898796214");
            Test.Check(solution.AddStrings, "987413248761378423", "135687461634894351", "1123100710396272774");
            Test.Check(solution.AddStrings, "9999999999999999999999999999999999999999999999999999999999999999999", "8888888888888888888888888888888888888888888888888888888888", "10000000008888888888888888888888888888888888888888888888888888888887");
        }

    }
}